import React from "react";
import { Card, Button, Row, Col } from "react-bootstrap";
import "./ConsultantCard.css";

class ConsultantCard extends React.Component {
	render() {
		const item = this.props.handleStudents;
		return (
			<Card className="Cardface">
				<Row>
					<Col className="col1">
						<Card.Body className="Body">
							<Card.Title className="card-title">
								<li>
									{item.firstName} {item.lastName}
								</li>
							</Card.Title>
							<Card.Img
								className="Image"
								src={"/Pics/" + item.firstName + "_" + item.lastName + ".jpg"}
							/>
							<Card.Text className="Text">
								<li>
									{"Stream: "} {item.stream}
								</li>
								<li>
									{"University: "} {item.university}
								</li>
								<li>
									{"Course: "} {item.degree}
								</li>
								<li>
									{"Grade: "} {item.grade}
								</li>
								<Button
									variant="light"
									href={item.cvLink + "&download=1"}
								>
									Download CV
								</Button>{" "}
							</Card.Text>
						</Card.Body>
					</Col>
					<Col className="col2">
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
