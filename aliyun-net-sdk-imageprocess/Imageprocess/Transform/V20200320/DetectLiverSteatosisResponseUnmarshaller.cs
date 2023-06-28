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
    public class DetectLiverSteatosisResponseUnmarshaller
    {
        public static DetectLiverSteatosisResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectLiverSteatosisResponse detectLiverSteatosisResponse = new DetectLiverSteatosisResponse();

			detectLiverSteatosisResponse.HttpResponse = _ctx.HttpResponse;
			detectLiverSteatosisResponse.RequestId = _ctx.StringValue("DetectLiverSteatosis.RequestId");
			detectLiverSteatosisResponse.Code = _ctx.StringValue("DetectLiverSteatosis.Code");
			detectLiverSteatosisResponse.Message = _ctx.StringValue("DetectLiverSteatosis.Message");

			DetectLiverSteatosisResponse.DetectLiverSteatosis_Data data = new DetectLiverSteatosisResponse.DetectLiverSteatosis_Data();

			List<string> data_spacing = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectLiverSteatosis.Data.Spacing.Length"); i++) {
				data_spacing.Add(_ctx.StringValue("DetectLiverSteatosis.Data.Spacing["+ i +"]"));
			}
			data.Spacing = data_spacing;

			List<string> data_origin = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectLiverSteatosis.Data.Origin.Length"); i++) {
				data_origin.Add(_ctx.StringValue("DetectLiverSteatosis.Data.Origin["+ i +"]"));
			}
			data.Origin = data_origin;

			List<DetectLiverSteatosisResponse.DetectLiverSteatosis_Data.DetectLiverSteatosis_DetectionsItem> data_detections = new List<DetectLiverSteatosisResponse.DetectLiverSteatosis_Data.DetectLiverSteatosis_DetectionsItem>();
			for (int i = 0; i < _ctx.Length("DetectLiverSteatosis.Data.Detections.Length"); i++) {
				DetectLiverSteatosisResponse.DetectLiverSteatosis_Data.DetectLiverSteatosis_DetectionsItem detectionsItem = new DetectLiverSteatosisResponse.DetectLiverSteatosis_Data.DetectLiverSteatosis_DetectionsItem();
				detectionsItem.Radius = _ctx.LongValue("DetectLiverSteatosis.Data.Detections["+ i +"].Radius");
				detectionsItem.LiverSlice = _ctx.FloatValue("DetectLiverSteatosis.Data.Detections["+ i +"].LiverSlice");
				detectionsItem.SpleenSlice = _ctx.FloatValue("DetectLiverSteatosis.Data.Detections["+ i +"].SpleenSlice");
				detectionsItem.LiverVolume = _ctx.FloatValue("DetectLiverSteatosis.Data.Detections["+ i +"].LiverVolume");
				detectionsItem.SpleenVolume = _ctx.FloatValue("DetectLiverSteatosis.Data.Detections["+ i +"].SpleenVolume");
				detectionsItem.LiverHU = _ctx.FloatValue("DetectLiverSteatosis.Data.Detections["+ i +"].LiverHU");
				detectionsItem.SpleenHU = _ctx.FloatValue("DetectLiverSteatosis.Data.Detections["+ i +"].SpleenHU");
				detectionsItem.LiverROI1 = _ctx.FloatValue("DetectLiverSteatosis.Data.Detections["+ i +"].LiverROI1");
				detectionsItem.LiverROI2 = _ctx.FloatValue("DetectLiverSteatosis.Data.Detections["+ i +"].LiverROI2");
				detectionsItem.LiverROI3 = _ctx.FloatValue("DetectLiverSteatosis.Data.Detections["+ i +"].LiverROI3");
				detectionsItem.SpleenROI = _ctx.FloatValue("DetectLiverSteatosis.Data.Detections["+ i +"].SpleenROI");
				detectionsItem.LiverSpleenDifference = _ctx.FloatValue("DetectLiverSteatosis.Data.Detections["+ i +"].LiverSpleenDifference");
				detectionsItem.LiverSpleenRatio = _ctx.FloatValue("DetectLiverSteatosis.Data.Detections["+ i +"].LiverSpleenRatio");
				detectionsItem.Prediction = _ctx.StringValue("DetectLiverSteatosis.Data.Detections["+ i +"].Prediction");
				detectionsItem.Probability = _ctx.FloatValue("DetectLiverSteatosis.Data.Detections["+ i +"].Probability");

				List<string> detectionsItem_rOI1Center = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectLiverSteatosis.Data.Detections["+ i +"].ROI1Center.Length"); j++) {
					detectionsItem_rOI1Center.Add(_ctx.StringValue("DetectLiverSteatosis.Data.Detections["+ i +"].ROI1Center["+ j +"]"));
				}
				detectionsItem.ROI1Center = detectionsItem_rOI1Center;

				List<string> detectionsItem_rOI2Center = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectLiverSteatosis.Data.Detections["+ i +"].ROI2Center.Length"); j++) {
					detectionsItem_rOI2Center.Add(_ctx.StringValue("DetectLiverSteatosis.Data.Detections["+ i +"].ROI2Center["+ j +"]"));
				}
				detectionsItem.ROI2Center = detectionsItem_rOI2Center;

				List<string> detectionsItem_rOI3Center = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectLiverSteatosis.Data.Detections["+ i +"].ROI3Center.Length"); j++) {
					detectionsItem_rOI3Center.Add(_ctx.StringValue("DetectLiverSteatosis.Data.Detections["+ i +"].ROI3Center["+ j +"]"));
				}
				detectionsItem.ROI3Center = detectionsItem_rOI3Center;

				List<string> detectionsItem_spleenCenter = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectLiverSteatosis.Data.Detections["+ i +"].SpleenCenter.Length"); j++) {
					detectionsItem_spleenCenter.Add(_ctx.StringValue("DetectLiverSteatosis.Data.Detections["+ i +"].SpleenCenter["+ j +"]"));
				}
				detectionsItem.SpleenCenter = detectionsItem_spleenCenter;

				data_detections.Add(detectionsItem);
			}
			data.Detections = data_detections;
			detectLiverSteatosisResponse.Data = data;
        
			return detectLiverSteatosisResponse;
        }
    }
}
