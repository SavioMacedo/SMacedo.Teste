import React, { Component } from 'react';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome'
import { faLocationDot, faWallet } from '@fortawesome/free-solid-svg-icons'

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
        <div className="container-sm w-50">
            <div className="row rounded">
                <div className="col active text-center">
                    Invited
                </div>
                <div className="col text-center">
                    Accepted
                </div>
            </div>
            <div className="row rounded">
                <div className="col p-0">
                    <div className="card">
                        <div className="card-body">
                            <div className="row ms-2">
                                <div className='col-1'>
                                    <div className="badge rounded-circle bg-warning text-wrap fs-3">
                                        B
                                    </div>
                                </div>
                                <div className='col-6 ms-4'>
                                    <h5 className="card-title fs-5">Bill</h5>
                                    <h6 className="card-subtitle fs-8 text-muted">January 4 @ 2:37 pm</h6>
                                </div>
                            </div>
                            <div className='row mt-3 ms-1'>
                                <div className='col-2'>
                                    <h6 className="card-subtitle fs-8 text-muted d-inline"><FontAwesomeIcon icon={faLocationDot} /><span className='ms-2'>Brasil 557</span></h6>
                                </div>
                                <div className='col-2'>
                                    <h6 className="card-subtitle fs-8 text-muted d-inline"><FontAwesomeIcon icon={faWallet} /><span className='ms-2'>Painters</span></h6>
                                </div>
                                <div className='col-3'>
                                    <h6 className="card-subtitle fs-8 text-muted d-inline">Job ID: 5597863</h6>
                                </div>
                            </div>
                            <div className='row mt-3 ms-1'>
                                <div className='col-12'>
                                    <h5 className="card-subtitle fs-8 text-muted d-inline">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum mattis enim dictum, consequat velit sed, elementum mauris. Etiam nec aliquet nulla.</h5>
                                </div>
                            </div>
                            <div className='row mt-5 ms-1'>
                                <div className='col-3 d-grid gap-2'>
                                    <a className="btn btn-warning rounded-0 border border-0 border-bottom border-5 border-dark border-opacity-25">Accept</a>
                                </div>
                                <div className='col-3 d-grid gap-2'>
                                    <a className="btn btn-secondary rounded-0 border border-0 border-bottom border-5 border-dark border-opacity-25">Decline</a>
                                </div>
                                <div className='col-4'>
                                    <span className="card-subtitle fs-8 text-muted d-inline"><h6 className='fw-semibold d-inline align-middle'>$62.00</h6><span className='ms-2 align-middle'>Lead Invitation</span></span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    );
  }
}
