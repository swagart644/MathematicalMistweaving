import React, { ChangeEvent, useEffect, useRef, useState } from "react";
import { Component } from "react";
import { DEFAULTS as statDefault, makeRequestUrl, REQUEST_URLS } from "../common/constants";
import MiscOptions from "./MiscellaneousOptions";
import Race from "./Race";
import Stats from "./Stats";


class Profile extends Component {
    render() {
        return (
            <p>
            <Race/>
            <Stats />
            <MiscOptions />
            </p>
        );
    } 
        
}

export default Profile;