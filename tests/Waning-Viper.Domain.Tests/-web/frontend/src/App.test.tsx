import React from 'react';
import { render, screen } from '@testing-library/react';
import App from './App';

describe('The main app', () => {

  it('should render the Orders link', () => {
    render(<App />);
    expect(screen.getByRole('link', { name: "Orders" })).toBeInTheDocument();
  });

  it('should render the Payments link', () => {
    render(<App />);
    expect(screen.getByRole('link', { name: "Payment" })).toBeInTheDocument();
  });

  it('should render the Home link', () => {
    render(<App />);
    expect(screen.getByRole('link', { name: "Home" })).toBeInTheDocument();
    //expect(screen.getByText('Home')).toBeInTheDocument();
  });

  it('should render the Home header', () => {
    render(<App />);
    expect(screen.getByRole('heading', { level: 2 })).toBeInTheDocument();
  });

});

// test('renders learn react link', () => {
//   render(<App />);
//   const linkElement = screen.getByText(/learn react/i);
//   expect(linkElement).toBeInTheDocument();
// });
