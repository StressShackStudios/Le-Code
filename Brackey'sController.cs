// Components
    Rigidbody body;
    // Animator

    // Movement Vars
    public float walk_Speed = 5.0f;
    public float run_Speed = 10.0f;

    // public float forwardDuration = 0.3f;
    // public float forwardTimer;

    // Look Vars
    public float sensitivity = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
        // Gets player button input form -1 to 1
        float x_Pos = Input.GetAxisRaw("Horizontal");
        float z_Pos = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * x_Pos;
        Vector3 moveVertical = transform.forward * z_Pos;

        Vector3 _velocity = (moveHorizontal + moveVertical).normalized * walk_Speed;

        
        
        // Gets player mouse input
        float x_Rot = Input.GetAxisRaw("Mouse X");
        float y_Rot = Input.GetAxisRaw("Mouse Y");

        Vector3 yaw = new Vector3(0f, x_Rot, 0f) * sensitivity;
        Vector3 vert = new Vector3(y_Rot, 0f, 0f) * sensitivity;


        
    }
