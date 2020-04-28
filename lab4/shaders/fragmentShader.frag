uniform sampler2D texture1;
uniform float tiled;
varying vec2 vUv;

void main() {
	// sample from the texture based on the uv coordinates
    if(tiled == 0.0){
        gl_FragColor = texture2D(texture1, vUv);
    }
    else{
        vec2 vUv2 = vUv * vec2(3.0, 3.0);
        if(vUv2.x > 2.0){
            vUv2.x -= 2.0;
        }
        else if(vUv2.x > 1.0){
            vUv2.x -= 1.0;
        }


        if(vUv2.y > 2.0){
            vUv2.y -= 2.0;
        }
        else if(vUv2.y > 1.0){
            vUv2.y -= 1.0;
        }
        
        gl_FragColor = texture2D(texture1, vUv2);
    }
}
