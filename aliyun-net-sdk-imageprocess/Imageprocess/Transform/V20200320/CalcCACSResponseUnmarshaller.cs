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
    public class CalcCACSResponseUnmarshaller
    {
        public static CalcCACSResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CalcCACSResponse calcCACSResponse = new CalcCACSResponse();

			calcCACSResponse.HttpResponse = _ctx.HttpResponse;
			calcCACSResponse.RequestId = _ctx.StringValue("CalcCACS.RequestId");
			calcCACSResponse.Code = _ctx.StringValue("CalcCACS.Code");
			calcCACSResponse.Message = _ctx.StringValue("CalcCACS.Message");

			CalcCACSResponse.CalcCACS_Data data = new CalcCACSResponse.CalcCACS_Data();
			data.ResultUrl = _ctx.StringValue("CalcCACS.Data.ResultUrl");
			data.Score = _ctx.StringValue("CalcCACS.Data.Score");
			data.VolumeScore = _ctx.StringValue("CalcCACS.Data.VolumeScore");

			List<CalcCACSResponse.CalcCACS_Data.CalcCACS_DetectionsItem> data_detections = new List<CalcCACSResponse.CalcCACS_Data.CalcCACS_DetectionsItem>();
			for (int i = 0; i < _ctx.Length("CalcCACS.Data.Detections.Length"); i++) {
				CalcCACSResponse.CalcCACS_Data.CalcCACS_DetectionsItem detectionsItem = new CalcCACSResponse.CalcCACS_Data.CalcCACS_DetectionsItem();
				detectionsItem.CalciumId = _ctx.LongValue("CalcCACS.Data.Detections["+ i +"].CalciumId");
				detectionsItem.CalciumScore = _ctx.FloatValue("CalcCACS.Data.Detections["+ i +"].CalciumScore");
				detectionsItem.CalciumVolume = _ctx.FloatValue("CalcCACS.Data.Detections["+ i +"].CalciumVolume");

				data_detections.Add(detectionsItem);
			}
			data.Detections = data_detections;
			calcCACSResponse.Data = data;
        
			return calcCACSResponse;
        }
    }
}
