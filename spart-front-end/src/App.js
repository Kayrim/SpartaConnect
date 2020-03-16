import React from "react";
import { Spinner, Container, Row, Col, ResponsiveEmbed } from "react-bootstrap/";
import ConsultantCard from "./Components/ConsultantCard";
import NavBar from "./Components/NavBar";
import Video from 'react-native-video'

class App extends React.Component {
  constructor(props) {
    super(props);

    this.state = {
      students: [],
      isLoaded: false
    };
  }

  componentDidMount() {
    fetch("http://localhost:56767/api/consultants")
      .then(res => res.json())
      .then(json => {
        this.setState({
          students: json,
          isLoaded: true
        });
      })
      .catch(err => {
        console.log(err);
      });
  }

  /**
   * render
   *
   * Render UI
   */
  render() {
    const { students } = this.state;
    return (
      <div>
        <NavBar />

        <Container>
          <Row>
            <Col><Video></Video></Col>
            <Col><ConsultantCard handleStudents={this.state.students} /></Col>
          </Row>
        </Container>
      </div>
    );
  }
}

export default App;
