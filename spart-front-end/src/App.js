import React from "react";
import { Container, Row, Col } from "react-bootstrap/";
import ConsultantCard from "./Components/ConsultantCard";
import NavBar from "./Components/NavBar";
import "../src/App.css";

class App extends React.Component {
	constructor(props) {
		super(props);
		this.state = {
			items: [],
			tempItems: [],
			isLoaded: false
		};
		this.updateFilter = this.updateFilter.bind(this);
	}

	componentDidMount() {
		fetch("http://localhost:56767/api/consultants")
			.then(res => res.json())
			.then(json => {
				this.setState({
					items: json,
					tempItems: json,
					isLoaded: true
				});
			})
			.catch(err => {
				console.log(err);
			});
	}

	updateFilter(e) {
		// Variable to hold the original version of the list
		let currentList = [];
		// Variable to hold the filtered list before putting into state
		let newList = [];

		// If the search bar isn't empty
		if (e.target.value !== "") {
			// Assign the original list to currentList
			currentList = this.state.items;

			newList = currentList.filter(item => {
				const lc = item.firstName.toLowerCase();
				const filter = e.target.value.toLowerCase();
				return lc.includes(filter);
			});
		} else {
			newList = this.state.items;
		}

		this.setState({
			tempItems: newList
		});
	}

	render() {
		const list = this.state.items;
		const filteredList = this.state.tempItems;

		return (
			<div>
				<NavBar handleList={list} TriggerListChange={this.updateFilter} />
				{filteredList.map(item => (
					<Container
						className="Container my-5"
						style={{ border: "4px solid white !important" }}
						key={item.consultantId}
					>
						<Row className="my-2">
							<Col className="m-auto">
								<video width="600" height="350" controls>
									<source src="/movie.mp4" type="video/mp4" />
								</video>
							</Col>
							<Col>
								<ConsultantCard handleStudents={item} />
							</Col>
						</Row>
					</Container>
				))}
			</div>
		);
	}
}

export default App;
