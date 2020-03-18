import React from "react";
import {
	Navbar,
	Nav,
	Form,
	FormControl,
	ButtonGroup,
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
				<Navbar>
					<Nav className="logo">
						<Navbar.Brand color="white">
							<img
								src="/Pics/spartaLogo.png"
								height="50"
								alt="Sparta global logo"
							/>
						</Navbar.Brand>
					</Nav>
					<h3 className="title">Sparta Connect</h3>
					<Nav className="filter">
						<ButtonGroup>
							<Button onClick={this.props.TriggerFilterChange} value="">
								All
							</Button>
							<Button onClick={this.props.TriggerFilterChange} value="DevOps">
								DevOps
							</Button>
							<Button onClick={this.props.TriggerFilterChange} value="BA">
								BA
							</Button>
							<DropdownButton
								as={ButtonGroup}
								title="Dev"
								id="bg-nested-dropdown"
							>
								<Button
									onClick={this.props.TriggerFilterChange}
									value="Developer"
								>
									All
								</Button>
								<Button onClick={this.props.TriggerFilterChange} value="C#">
									C#
								</Button>
								<Button onClick={this.props.TriggerFilterChange} value="Java">
									Java
								</Button>
							</DropdownButton>
						</ButtonGroup>
						<Form className="pull-right inline">
							<FormControl
								type="text"
								onChange={this.props.TriggerListChange}
								placeholder="Search"
							/>
						</Form>
					</Nav>
				</Navbar>
			</div>
		);
	}
}

export default NavBar;
