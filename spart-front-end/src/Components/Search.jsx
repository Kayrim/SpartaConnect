import React, { Component } from "react";
import { Button, ButtonGroup, Form, FormControl } from "react-bootstrap";
import "./Search.css";

class Search extends Component {
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
			<div className="search-container xl-2">
				<ButtonGroup className="button-group">
					<Button
						variant="secondary"
						onClick={this.props.TriggerFilterChange}
						value=""
					>
						All
					</Button>
					<Button
						variant="secondary"
						onClick={this.props.TriggerFilterChange}
						value="DevOps"
					>
						DevOps
					</Button>
					<Button
						variant="secondary"
						onClick={this.props.TriggerFilterChange}
						value="BA"
					>
						BA
					</Button>
					<Button
						variant="secondary"
						onClick={this.props.TriggerFilterChange}
						value="Developer"
					>
						Developers
					</Button>
					<Button
						variant="secondary"
						onClick={this.props.TriggerFilterChange}
						value="C#"
					>
						C#
					</Button>
					<Button
						variant="secondary"
						onClick={this.props.TriggerFilterChange}
						value="Java"
					>
						Java
					</Button>
				</ButtonGroup>

				<Form className="w-25 search">
					<FormControl
						type="text"
						onChange={this.props.TriggerListChange}
						placeholder="Search by name"
					/>
				</Form>
			</div>
		);
	}
}

export default Search;
