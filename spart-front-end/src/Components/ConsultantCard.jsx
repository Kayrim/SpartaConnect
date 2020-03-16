import React, { Component } from "react";
import { Card, Button } from "react-bootstrap";

class ConsultantCard extends React.Component {
	constructor(props) {
		super(props);
	}

	downloadCv(item) {
		item = this.props.handleStudents;
		return item.cvLink + "&download=1";
	}

	render() {
		const item = this.props.handleStudents;
		return (
			<Card
				className="mt-2"
				bg="light"
				variant="light"
				style={{ alignItems: "center", width: "18rem" }}
			>
				<Card.Img
					variant="top"
					src="https://www.thesprucepets.com/thmb/ngEcQBHHXcHYXh8PPTvGttRxYN0=/960x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/high-angle-view-of-chimpanzee-in-forest-769784687-5b1e76d63de4230037ce6f9d.jpg"
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
							{"Bio: "} {item.bio}
						</li>
						<Button href={item.cvLink + "&download=1"}>Download CV</Button>{" "}
					</Card.Text>
				</Card.Body>
			</Card>
		);
	}
}

export default ConsultantCard;
