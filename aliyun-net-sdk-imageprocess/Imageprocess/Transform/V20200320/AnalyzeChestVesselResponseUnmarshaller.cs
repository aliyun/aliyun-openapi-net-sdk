/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.imageprocess.Model.V20200320;

namespace Aliyun.Acs.imageprocess.Transform.V20200320
{
    public class AnalyzeChestVesselResponseUnmarshaller
    {
        public static AnalyzeChestVesselResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AnalyzeChestVesselResponse analyzeChestVesselResponse = new AnalyzeChestVesselResponse();

			analyzeChestVesselResponse.HttpResponse = _ctx.HttpResponse;
			analyzeChestVesselResponse.RequestId = _ctx.StringValue("AnalyzeChestVessel.RequestId");
			analyzeChestVesselResponse.Code = _ctx.StringValue("AnalyzeChestVessel.Code");
			analyzeChestVesselResponse.Message = _ctx.StringValue("AnalyzeChestVessel.Message");

			AnalyzeChestVesselResponse.AnalyzeChestVessel_Data data = new AnalyzeChestVesselResponse.AnalyzeChestVessel_Data();
			data.ResultURL = _ctx.StringValue("AnalyzeChestVessel.Data.ResultURL");

			AnalyzeChestVesselResponse.AnalyzeChestVessel_Data.AnalyzeChestVessel_AortaInfo aortaInfo = new AnalyzeChestVesselResponse.AnalyzeChestVessel_Data.AnalyzeChestVessel_AortaInfo();
			aortaInfo.MaxAreaIndex = _ctx.LongValue("AnalyzeChestVessel.Data.AortaInfo.MaxAreaIndex");
			aortaInfo.MaxArea = _ctx.FloatValue("AnalyzeChestVessel.Data.AortaInfo.MaxArea");
			aortaInfo.MaxDiameter = _ctx.FloatValue("AnalyzeChestVessel.Data.AortaInfo.MaxDiameter");
			aortaInfo.LabelValue = _ctx.LongValue("AnalyzeChestVessel.Data.AortaInfo.LabelValue");

			List<string> aortaInfo_coordinates = new List<string>();
			for (int i = 0; i < _ctx.Length("AnalyzeChestVessel.Data.AortaInfo.Coordinates.Length"); i++) {
				aortaInfo_coordinates.Add(_ctx.StringValue("AnalyzeChestVessel.Data.AortaInfo.Coordinates["+ i +"]"));
			}
			aortaInfo.Coordinates = aortaInfo_coordinates;

			List<string> aortaInfo_area = new List<string>();
			for (int i = 0; i < _ctx.Length("AnalyzeChestVessel.Data.AortaInfo.Area.Length"); i++) {
				aortaInfo_area.Add(_ctx.StringValue("AnalyzeChestVessel.Data.AortaInfo.Area["+ i +"]"));
			}
			aortaInfo.Area = aortaInfo_area;
			data.AortaInfo = aortaInfo;

			AnalyzeChestVesselResponse.AnalyzeChestVessel_Data.AnalyzeChestVessel_PulmonaryInfo pulmonaryInfo = new AnalyzeChestVesselResponse.AnalyzeChestVessel_Data.AnalyzeChestVessel_PulmonaryInfo();
			pulmonaryInfo.MaxAreaIndex = _ctx.LongValue("AnalyzeChestVessel.Data.PulmonaryInfo.MaxAreaIndex");
			pulmonaryInfo.MaxArea = _ctx.FloatValue("AnalyzeChestVessel.Data.PulmonaryInfo.MaxArea");
			pulmonaryInfo.MaxDiameter = _ctx.FloatValue("AnalyzeChestVessel.Data.PulmonaryInfo.MaxDiameter");
			pulmonaryInfo.LabelValue = _ctx.LongValue("AnalyzeChestVessel.Data.PulmonaryInfo.LabelValue");
			pulmonaryInfo.NearestAortaArea = _ctx.FloatValue("AnalyzeChestVessel.Data.PulmonaryInfo.NearestAortaArea");

			List<string> pulmonaryInfo_coordinates1 = new List<string>();
			for (int i = 0; i < _ctx.Length("AnalyzeChestVessel.Data.PulmonaryInfo.Coordinates.Length"); i++) {
				pulmonaryInfo_coordinates1.Add(_ctx.StringValue("AnalyzeChestVessel.Data.PulmonaryInfo.Coordinates["+ i +"]"));
			}
			pulmonaryInfo.Coordinates1 = pulmonaryInfo_coordinates1;

			List<string> pulmonaryInfo_area2 = new List<string>();
			for (int i = 0; i < _ctx.Length("AnalyzeChestVessel.Data.PulmonaryInfo.Area.Length"); i++) {
				pulmonaryInfo_area2.Add(_ctx.StringValue("AnalyzeChestVessel.Data.PulmonaryInfo.Area["+ i +"]"));
			}
			pulmonaryInfo.Area2 = pulmonaryInfo_area2;
			data.PulmonaryInfo = pulmonaryInfo;
			analyzeChestVesselResponse.Data = data;
        
			return analyzeChestVesselResponse;
        }
    }
}
