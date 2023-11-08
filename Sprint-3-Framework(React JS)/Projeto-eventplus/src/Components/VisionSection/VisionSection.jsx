import React from 'react';
import Title from '../Title/Title';
import './VisionSection.css'

const VisionSection = () => {
    return (
        <section className='vision'>
            <div className='vision__box'>
                <Title
                    titleText={"Vision"}
                    color='White'
                    additionalClass='vision__title'
                />

                <p>Lorem, ipsum.</p>
            </div>
        </section>
    );
};

export default VisionSection;