package com.in28minutes.rest.webservices.restfulwebservices;

import org.springframework.web.bind.annotation.*;

//Controller
@RestController
public class HelloWorldController {
    // Get
    // URI - /hello-world
    // method - "Hello world"
   /* @GetMapping(method = RequestMethod.GET, path = "/hello-world")*/
    @GetMapping( path = "/hello-world")
    public String helloWorld(){
        return "Hello world";
    }
    @GetMapping( path = "/hello-world-bean")
    public HelloWorldBean helloWorldBean(){
        return new HelloWorldBean("Hello world");
    }

    //hello-world/path-variable/in28minutes
    @GetMapping(path = "hello-world/path-variable/{name}")
    public HelloWorldBean helloWorldBean(@PathVariable String name){
        return new HelloWorldBean(String.format("Hello world, %s",name));
    }
}
