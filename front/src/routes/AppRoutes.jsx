import { Routes, Route, Navigate } from "react-router-dom";

import Main from "../pages/Main";
import HowToUse from "../pages/HowToUse";
import Courses from "../pages/Courses";

import NotFound from "../pages/NotFound";

const AppRoutes = () => {
  return (
    <Routes>
      <Route path="/" element={<Navigate to="/main" />} />
      <Route path="/main" element={<Main />} />
      <Route path="/how-to-use" element={<HowToUse />} />
      <Route path="/courses" element={<Courses />} />
      <Route path="*" element={<NotFound />} />
    </Routes>
  );
};

export default AppRoutes;
