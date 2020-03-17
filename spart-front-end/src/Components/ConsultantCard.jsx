import React from "react";
import { Card, Button, Row, Col } from "react-bootstrap";
import "./ConsultantCard.css";

class ConsultantCard extends React.Component {
	render() {
		const item = this.props.handleStudents;
		return (
			<Row>
				<Col>
					<Card
						className="mt-2"
						bg="dark"
						text="light"
						style={{ alignItems: "center", width: "35rem" }}
					>
						<Card.Img
							className="Image"
							variant="top"
							src={"/Pics/" + item.firstName + "_" + item.lastName + ".jpg"}
						/>
						<Card.Body>
							<Card.Title>
								<li style={{ listStyleType: "none" }}>
									{"Name: "}
									{item.firstName} {item.lastName}
								</li>
							</Card.Title>
							<Card.Text>
								<li style={{ listStyleType: "none" }}>
									{"Stream: "} {"C# Dev"}
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
					</Card>
				</Col>
				<Col>
					<li className="list" style={{ listStyleType: "none" }}>
						{"Bio: "} {item.bio}
					</li>
				</Col>
			</Row>
		);
	}
}

export default ConsultantCard;
