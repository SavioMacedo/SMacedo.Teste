import React, { Component } from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faLocationDot, faWallet } from '@fortawesome/free-solid-svg-icons'

export class LeadInvited extends Component {

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div className="row rounded shadow border-5 border-dark">
                <div className="col p-0">
                    <div className="card">
                        <div className="card-body">
                            <div className="row ms-2">
                                <div className='col-1'>
                                    <div className="badge rounded-circle bg-warning text-wrap fs-3">
                                        {this.props.Name[0]}
                                    </div>
                                </div>
                                <div className='col-6 ms-4'>
                                    <h5 className="card-title fs-5">{this.props.Name}</h5>
                                    <h6 className="card-subtitle fs-8 text-muted">{this.props.CreateDate}</h6>
                                </div>
                            </div>
                            <div className='row mt-3 ms-1'>
                                <div className='col-3'>
                                    <h6 className="card-subtitle fs-8 text-muted d-inline"><FontAwesomeIcon icon={faLocationDot} /><span className='ms-2'>{this.props.Location}</span></h6>
                                </div>
                                <div className='col-2'>
                                    <h6 className="card-subtitle fs-8 text-muted d-inline"><FontAwesomeIcon icon={faWallet} /><span className='ms-2'>{this.props.Category}</span></h6>
                                </div>
                                <div className='col-3'>
                                    <h6 className="card-subtitle fs-8 text-muted d-inline">Job ID: {this.props.JobId}</h6>
                                </div>
                            </div>
                            <div className='row mt-3 ms-1'>
                                <div className='col-12'>
                                    <h5 className="card-subtitle fs-8 text-muted d-inline">{this.props.JobDescription}</h5>
                                </div>
                            </div>
                            <div className='row mt-4 ms-1'>
                                <div className='col-3 d-grid gap-2'>
                                    <a className="btn btn-warning rounded-0 border border-0 border-bottom border-5 border-dark border-opacity-25">Accept</a>
                                </div>
                                <div className='col-3 d-grid gap-2'>
                                    <a className="btn btn-secondary rounded-0 border border-0 border-bottom border-5 border-dark border-opacity-25">Decline</a>
                                </div>
                                <div className='col-4'>
                                    <span className="card-subtitle fs-8 text-muted d-inline"><h6 className='fw-semibold d-inline align-middle'>${this.props.Value}</h6><span className='ms-2 align-middle'>Lead Invitation</span></span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            );
    }
}