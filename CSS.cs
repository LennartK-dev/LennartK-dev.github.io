header {
    height: 6.25rem;
    width: 100%;
    position: fixed;
    -webkit-backface-visibility: hidden;
    backface-visibility: hidden;
    top: 0;
    left: 0;
    z-index: 100;
    background-color: #006ec0;
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-flex-direction: row;
    -moz-box-flex-direction: row;
    -ms-flex-direction: row;
    -webkit-box-orient: horizontal;
    -webkit-box-direction: normal;
    flex-direction: row;
    -webkit-transition: all .4s cubic-bezier(.165,.84,.44,1);
    transition: all .4s cubic-bezier(.165,.84,.44,1)
}

.blue_bar_titel {
    -webkit-box-flex: 1 1 auto;
    -ms-flex: 1 1 auto;
    flex: 1 1 auto;
    -webkit-box-align-self: center;
    -moz-box-align-self: center;
    -webkit-align-self: center;
    -ms-align-self: center;
    -ms-flex-item-align: center;
    align-self: center;
    margin: 0;
    font-size: 3rem;
    font-weight: var(--font-weight-semibold);
    text-align: left;
    color: #fff;
    overflow: hidden;
    white-space: nowrap;
    text-overflow: ellipsis;
    text-align: center;
    -webkit-transition: all .15s;
    transition: all .15s;
    cursor: pointer
}