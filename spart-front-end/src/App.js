import React from "react";
import { Container, Row, Col } from "react-bootstrap/";
import ConsultantCard from "./Components/ConsultantCard";
import NavBar from "./Components/NavBar";
import "../src/App.css";

class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      items: [],
      tempItems: [],
      isStreamFiltered: false,
      isNameFiltered: false,
      isLoaded: false
    };
    this.updateFilter = this.updateFilter.bind(this);
    this.updateFilterByStream = this.updateFilterByStream.bind(this);
  }

  componentDidMount() {
    fetch("http://localhost:56767/api/consultants")
      .then(res => res.json())
      .then(json => {
        this.setState({
          items: json,
          tempItems: json,
          isLoaded: true
        });
      })
      .catch(err => {
        console.log(err);
      });
  }

  updateFilter(e) {
    this.setState({ isNameFiltered: false });
    // Variable to hold the original version of the list
    let currentList = [];
    // Variable to hold the filtered list before putting into state
    let newList = [];

    // If the search bar isn't empty
    if (e.target.value !== "") {
      // Assign the original list to currentList
      if (this.state.isStreamFiltered) {
        currentList = this.state.tempItems;
      } else {
        currentList = this.state.items;
      }
      newList = currentList.filter(item => {
        const lc = item.firstName.toLowerCase();
        const filter = e.target.value.toLowerCase();
        return lc.includes(filter);
      });
    } else {
      newList = this.state.items;
    }

    this.setState({
      tempItems: newList,
      isNameFiltered: true
    });
  }

  updateFilterByStream(e) {
    // Variable to hold the original version of the list
    let currentList = [];
    // Variable to hold the filtered list before putting into state
    let newList = [];

    // If the search bar isn't empty
    if (e.target.value !== "") {
      // Assign the original list to currentList
      if (this.state.isNameFiltered) {
        currentList = this.state.tempItems;
      } else {
        currentList = this.state.items;
      }

      newList = currentList.filter(item => {
        const lc = item.stream.toLowerCase();
        const filter = e.target.value.toLowerCase();
        return lc.includes(filter);
      });
    } else {
      newList = this.state.items;
    }

    this.setState({
      tempItems: newList,
      isStreamFiltered: true
    });
  }

  render() {
    const list = this.state.items;
    const filteredList = this.state.tempItems;

    return (
      <div>
        <NavBar
          handleList={list}
          TriggerFilterChange={this.updateFilterByStream}
          TriggerListChange={this.updateFilter}
        />
        {filteredList.map(item => (
          <Container key={item.consultantId}>
            <Row>
              <Col className="col1">
                <video width="600" height="350" controls>
                  <source src="/movie.mp4" type="video/mp4" />
                </video>
              </Col>
              <Col className="col2">
                <ConsultantCard handleStudents={item} />
              </Col>
            </Row>
          </Container>
        ))}
      </div>
    );
  }
}

export default App;
