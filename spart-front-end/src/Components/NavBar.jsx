import React from "react";
import {
  Navbar,
  Nav,
  Form,
  FormControl,
  Button
} from "react-bootstrap";

function NavBar() {
  return (
    <div>
      <Navbar bg="dark" expand="lg">
        <Nav className="mr-auto">
            <Navbar.Brand color="white"> 
                <img src="https://lh3.googleusercontent.com/proxy/B5V_PRJ8BoDeR0CD-TRjinW9K3UXMG__2POcipphKJ2sqWMQ_rndoG3l06Ij5N3Df7JOA5TJQ5CXTSCOtKaJFnBmNL1WVlYkobkBrWJjBezvbEb9klwBHBvxDg7oRQXKSxYUTIxHaT-mUAmBpQ" height="50" alt="Sparta global logo"/>
            </Navbar.Brand>
        </Nav>
        <Nav>
            <Form float-lg-right inline className="pull-right">
              <FormControl type="text" placeholder="Search" className="mr-sm-2" />
              <Button variant="outline-success">Search</Button>
            </Form>
        </Nav>
      </Navbar>
    </div>
  );
}

export default NavBar;
