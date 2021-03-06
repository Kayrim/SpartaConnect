import React from "react";
import { Card, Button, Row, Col } from "react-bootstrap";
import "./ConsultantCard.css";

class ConsultantCard extends React.Component {
	render() {
		const item = this.props.handleStudents;
		return (
			<Card className="Cardface text-center">
				<Row>
					<Col className="col-profile" xs="5">
						<Card.Body className="Body">
							<Card.Title>
								<li className="card-name">
									{item.firstName} {item.lastName}
								</li>
							</Card.Title>
							<Card.Img className="Image" src={item.photoLink} />
							<Card.Text className="Text">
								<li className="info">
									<span className="bold">{"Stream: "} </span> {item.stream}
								</li>
								<li className="info">
									<span className="bold">{"University: "} </span>
									{item.university}
								</li>
								<li className="info">
									<span className="bold">{"Course: "} </span> {item.degree}
								</li>
								<li className="info">
									<span className="bold">{"Grade: "} </span> {item.grade}
								</li>
								<Button
									className="button-cv"
									variant="secondary"
									href={item.cvLink + "&download=1"}
								>
									Download Profile {"  "}
									<img className="align" alt="" src="Icons\Download.png" />
								</Button>{" "}
							</Card.Text>
						</Card.Body>
					</Col>
					<Col className="col-bio">
						<li className="bio" style={{ listStyleType: "none" }}>
							{item.bio}
						</li>
					</Col>
				</Row>
			</Card>
		);
	}
}

export default ConsultantCard;
