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
    public class CalcBMDResponseUnmarshaller
    {
        public static CalcBMDResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CalcBMDResponse calcBMDResponse = new CalcBMDResponse();

			calcBMDResponse.HttpResponse = _ctx.HttpResponse;
			calcBMDResponse.RequestId = _ctx.StringValue("CalcBMD.RequestId");
			calcBMDResponse.Code = _ctx.StringValue("CalcBMD.Code");
			calcBMDResponse.Message = _ctx.StringValue("CalcBMD.Message");

			CalcBMDResponse.CalcBMD_Data data = new CalcBMDResponse.CalcBMD_Data();
			data.ResultURL = _ctx.StringValue("CalcBMD.Data.ResultURL");

			List<string> data_spacing = new List<string>();
			for (int i = 0; i < _ctx.Length("CalcBMD.Data.Spacing.Length"); i++) {
				data_spacing.Add(_ctx.StringValue("CalcBMD.Data.Spacing["+ i +"]"));
			}
			data.Spacing = data_spacing;

			List<string> data_origin = new List<string>();
			for (int i = 0; i < _ctx.Length("CalcBMD.Data.Origin.Length"); i++) {
				data_origin.Add(_ctx.StringValue("CalcBMD.Data.Origin["+ i +"]"));
			}
			data.Origin = data_origin;

			List<CalcBMDResponse.CalcBMD_Data.CalcBMD_DetectionsItem> data_detections = new List<CalcBMDResponse.CalcBMD_Data.CalcBMD_DetectionsItem>();
			for (int i = 0; i < _ctx.Length("CalcBMD.Data.Detections.Length"); i++) {
				CalcBMDResponse.CalcBMD_Data.CalcBMD_DetectionsItem detectionsItem = new CalcBMDResponse.CalcBMD_Data.CalcBMD_DetectionsItem();
				detectionsItem.VertId = _ctx.StringValue("CalcBMD.Data.Detections["+ i +"].VertId");
				detectionsItem.VertBMD = _ctx.FloatValue("CalcBMD.Data.Detections["+ i +"].VertBMD");
				detectionsItem.VertTScore = _ctx.FloatValue("CalcBMD.Data.Detections["+ i +"].VertTScore");
				detectionsItem.VertZScore = _ctx.FloatValue("CalcBMD.Data.Detections["+ i +"].VertZScore");
				detectionsItem.VertCategory = _ctx.FloatValue("CalcBMD.Data.Detections["+ i +"].VertCategory");

				data_detections.Add(detectionsItem);
			}
			data.Detections = data_detections;
			calcBMDResponse.Data = data;
        
			return calcBMDResponse;
        }
    }
}
