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

	componentDidMount = () => {
		this.setState({
			list: this.props.handleList
		});
	};

	render() {
		return (
			<div>
				<Navbar bg="dark" expand="lg">
					<Nav className="mr-auto">
						<Navbar.Brand color="white">
							<img
								src="/Pics/spartaLogo.png"
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
								type="text"
								onChange={this.props.TriggerListChange}
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