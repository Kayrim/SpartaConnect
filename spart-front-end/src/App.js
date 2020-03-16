import React from "react";
import { Container, Row, Col } from "react-bootstrap/";
import ConsultantCard from "./Components/ConsultantCard";
import NavBar from "./Components/NavBar";

class App extends React.Component {
	constructor(props) {
		super(props);

		this.state = {
			items: [],
			isLoaded: false
		};
	}

	componentDidMount() {
		fetch("http://localhost:56767/api/consultants")
			.then(res => res.json())
			.then(json => {
				this.setState({
					items: json,
					isLoaded: true
				});
			})
			.catch(err => {
				console.log(err);
			});
	}

	/**
	 * render
	 *
	 * Render UI
	 */
	render() {
		const list = this.state.items;

		return (
			<div>
				<NavBar />
				{list.map(item => (
					<Container key={item.consultantId}>
						<Row>
							<Col>
								<video width="500" height="300" controls>
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
