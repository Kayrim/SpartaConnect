import React from "react";
import { Navbar, Nav } from "react-bootstrap";
import "./Navbar.css";

class NavBar extends React.Component {
	render() {
		return (
			<div>
				<Navbar expand="lg" className="justify-content-between bg-dark">
					<Nav className="logo">
						<Navbar.Brand color="white">
							<img
								src="/Pics/spartaLogo.png"
								height="50"
								alt="Sparta global logo"
							/>
						</Navbar.Brand>
					</Nav>
					<h3 className="title">Sparta Profiles</h3>
				</Navbar>
			</div>
		);
	}
}

export default NavBar;
