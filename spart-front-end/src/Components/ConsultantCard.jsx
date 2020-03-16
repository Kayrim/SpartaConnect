import React, { Component } from 'react';
import Card from 'react-bootstrap/Card';
import App from '../App';


class ConsultantCard extends React.Component {
    constructor(props){
        super(props);

    }
    render() {
      const list = this.props.handleStudents;
        return (
            <Card
          bg="light"
          variant="light"
          style={{ alignItems: "center", width: "18rem" }}
        >
          <Card.Img variant="top" src="https://www.thesprucepets.com/thmb/ngEcQBHHXcHYXh8PPTvGttRxYN0=/960x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/high-angle-view-of-chimpanzee-in-forest-769784687-5b1e76d63de4230037ce6f9d.jpg" />
          <Card.Body>
            <Card.Title>
              {list
                .filter(s => s.consultantId === 1)
                .map(st => (
                  <li>
                    {" "}
                    {st.firstName} {st.lastName}
                  </li>
                ))}
            </Card.Title>
            <Card.Text>
              {list
                .filter(s => s.consultantId === 1)
                .map(st => (
                  <li> {st.bio}</li>
                ))}
            </Card.Text>
          </Card.Body>
        </Card>
        );
    }
}

export default ConsultantCard;
