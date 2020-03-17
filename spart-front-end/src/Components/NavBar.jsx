import React from "react";
import {
	Navbar,
	Nav,
	Form,
	FormControl,
	ButtonGroup,
	Dropdown,
	Button,
	DropdownButton
} from "react-bootstrap";

class NavBar extends React.Component {
	constructor(props) {
		super(props);
		this.state = {
			list: []
		};
	}

	render() {
		const list = this.props.handleList;

		console.log(list);
		return (
			<div>
				<Navbar bg="dark" expand="lg">
					<Nav className="mr-auto">
						<Navbar.Brand color="white">
							<img
								src="https://lh3.googleusercontent.com/proxy/B5V_PRJ8BoDeR0CD-TRjinW9K3UXMG__2POcipphKJ2sqWMQ_rndoG3l06Ij5N3Df7JOA5TJQ5CXTSCOtKaJFnBmNL1WVlYkobkBrWJjBezvbEb9klwBHBvxDg7oRQXKSxYUTIxHaT-mUAmBpQ"
								height="50"
								alt="Sparta global logo"
							/>
						</Navbar.Brand>
					</Nav>
					<Nav>
						<ButtonGroup>
							<Button>SDET</Button>
							<Button>BA</Button>
							<DropdownButton
								as={ButtonGroup}
								title="Dev"
								id="bg-nested-dropdown"
							>
								<Dropdown.Item eventKey="1">All</Dropdown.Item>
								<Dropdown.Item eventKey="2">C#</Dropdown.Item>
								<Dropdown.Item eventKey="3">Java</Dropdown.Item>
							</DropdownButton>
						</ButtonGroup>
						<Form className="pull-right inline">
							<FormControl
								type="input"
								placeholder="Search"
								className="mr-sm-2"
							/>
						</Form>
					</Nav>
				</Navbar>
			</div>
		);
	}
}

export default NavBar;
