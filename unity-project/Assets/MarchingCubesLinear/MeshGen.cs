using System.Collections.Generic;
using UnityEngine;

public class MeshGen : MonoBehaviour
{
    public Vector3 size = new Vector3(3, 3, 3);
    public float zoom = 1f;
    public float noise = 0.5f;
    public Material mat = null;
    private Point[,,] point = null;
    private List<Vector3> vert = new List<Vector3>();
    private List<int> tri = new List<int>();
    private List<Vector2> uv = new List<Vector2>();
    private GridCell cell = new GridCell();

    private void Start()
    {
        //randomize at runtime
        zoom = Random.Range(24f, 26f);
        noise = Random.Range(0.47f, 0.5f);

        Initialize();
        BuildMesh();
    }
    private void Initialize()
    {
        point = new Point[(int)size.x + 1, (int)size.y + 1, (int)size.z + 1];

        for (int z = 0; z <= size.z; z++)
        {
            for (int y = 0; y <= size.y; y++)
            {
                for (int x = 0; x <= size.x; x++)
                {
                    float nx = zoom * (x / size.x);
                    float ny = zoom * (y / size.y);
                    float nz = zoom * (z / size.z);
                    point[x, y, z] = new Point();
                    point[x, y, z].Position = new Vector3(x, y, z);
                    point[x, y, z].number = MarchingCube.Perlin3D(nx, ny, nz);
                }
            }
        }
    }
    private void BuildMesh()
    {
        //get the mesh
        GameObject gameObject = this.gameObject;
        MarchingCube.GetMesh(ref gameObject, ref mat, true);



        vert.Clear();
        tri.Clear();
        uv.Clear();

        //building lists
        //for every cell
        for (int z = 0; z < size.z; z++)
        {
            for (int y = 0; y < size.y; y++)
            {
                for (int x = 0; x < size.x; x++)
                {
                    cell.p[0] = point[x, y, z + 1];
                    cell.p[1] = point[x + 1, y, z + 1];
                    cell.p[2] = point[x + 1, y, z];
                    cell.p[3] = point[x, y, z];
                    cell.p[4] = point[x, y + 1, z + 1];
                    cell.p[5] = point[x + 1, y + 1, z + 1];
                    cell.p[6] = point[x + 1, y + 1, z];
                    cell.p[7] = point[x, y + 1, z];
                    //build triangles/faces for that cell based on noise level       
                    MarchingCube.IsoFaces(ref cell, noise);
                    BuildMeshCellData(ref cell);
                }
            }
        }

        Vector3[] av = vert.ToArray();
        int[] at = tri.ToArray();
        Vector2[] au = uv.ToArray();
        MarchingCube.SetMesh(ref gameObject, ref av, ref at, ref au);
    }

    private void BuildMeshCellData(ref GridCell cell)
    {
        //alternate between UVs to get whole texture
        bool alternate = false;

        for (int i = 0; i < cell.numberOfTriangles; i++)
        {

            vert.Add(cell.tri[i].parts[0]);
            vert.Add(cell.tri[i].parts[1]);
            vert.Add(cell.tri[i].parts[2]);


            //connect points of triangle in this order to make sure it renders correctly
            tri.Add(vert.Count - 3);
            tri.Add(vert.Count - 2);
            tri.Add(vert.Count - 1);

            if (alternate == true)
            {
                uv.Add(UVCoordinate.First);
                uv.Add(UVCoordinate.Third);
                uv.Add(UVCoordinate.Fourth);
            }
            else
            {
                uv.Add(UVCoordinate.First);
                uv.Add(UVCoordinate.Second);
                uv.Add(UVCoordinate.Third);
            }
            alternate = !alternate;
        }
    }
}