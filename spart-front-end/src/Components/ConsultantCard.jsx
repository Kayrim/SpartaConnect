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
							<Card.Title className="mx-auto">
								<li className="list" style={{ listStyleType: "none" }}>
									{item.firstName} {item.lastName}
								</li>
							</Card.Title>
							<Card.Img
								className="Image"
								src={"/Pics/" + item.firstName + "_" + item.lastName + ".jpg"}
							/>
							<Card.Text className="Text">
								<li className="list" style={{ listStyleType: "none" }}>
									{"Stream: "} {item.stream}
								</li>
								<li className="list" style={{ listStyleType: "none" }}>
									{"University: "} {item.university}
								</li>
								<li className="list" style={{ listStyleType: "none" }}>
									{"Course: "} {item.degree}
								</li>
								<li className="list" style={{ listStyleType: "none" }}>
									{"Grade: "} {item.grade}
								</li>
								<Button
									variant="light"
									style={{ marginTop: "1rem" }}
									href={item.cvLink + "&download=1"}
								>
									Download CV
								</Button>{" "}
							</Card.Text>
						</Card.Body>
					</Col>
					<Col className="col2 my-auto">
						<li className="list" style={{ listStyleType: "none" }}>
							{item.bio}
						</li>
					</Col>
				</Row>
			</Card>
		);
	}
}

export default ConsultantCard;
