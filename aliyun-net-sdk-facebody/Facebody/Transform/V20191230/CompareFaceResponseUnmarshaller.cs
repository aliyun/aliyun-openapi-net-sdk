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
using Aliyun.Acs.facebody.Model.V20191230;

namespace Aliyun.Acs.facebody.Transform.V20191230
{
    public class CompareFaceResponseUnmarshaller
    {
        public static CompareFaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CompareFaceResponse compareFaceResponse = new CompareFaceResponse();

			compareFaceResponse.HttpResponse = _ctx.HttpResponse;
			compareFaceResponse.RequestId = _ctx.StringValue("CompareFace.RequestId");

			CompareFaceResponse.CompareFace_Data data = new CompareFaceResponse.CompareFace_Data();
			data.Confidence = _ctx.FloatValue("CompareFace.Data.Confidence");

			List<string> data_thresholds = new List<string>();
			for (int i = 0; i < _ctx.Length("CompareFace.Data.Thresholds.Length"); i++) {
				data_thresholds.Add(_ctx.StringValue("CompareFace.Data.Thresholds["+ i +"]"));
			}
			data.Thresholds = data_thresholds;

			List<string> data_rectAList = new List<string>();
			for (int i = 0; i < _ctx.Length("CompareFace.Data.RectAList.Length"); i++) {
				data_rectAList.Add(_ctx.StringValue("CompareFace.Data.RectAList["+ i +"]"));
			}
			data.RectAList = data_rectAList;

			List<string> data_rectBList = new List<string>();
			for (int i = 0; i < _ctx.Length("CompareFace.Data.RectBList.Length"); i++) {
				data_rectBList.Add(_ctx.StringValue("CompareFace.Data.RectBList["+ i +"]"));
			}
			data.RectBList = data_rectBList;
			compareFaceResponse.Data = data;
        
			return compareFaceResponse;
        }
    }
}
