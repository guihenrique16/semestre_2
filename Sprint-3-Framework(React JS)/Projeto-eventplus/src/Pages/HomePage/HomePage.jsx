import React from 'react';
import './HomePage.css';
import VisionSection from '../../Components/VisionSection/VisionSection';
import MainContent from '../../Components/MainContent/MainContent';
import Banner from '../../Components/Banner/Banner';

const HomePage = () => {
    return (
        <MainContent>

            <Banner/>

            <VisionSection/>
            
        </MainContent>
    );
};

export default HomePage;