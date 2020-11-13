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
    public class VerifyFaceMaskResponseUnmarshaller
    {
        public static VerifyFaceMaskResponse Unmarshall(UnmarshallerContext context)
        {
			VerifyFaceMaskResponse verifyFaceMaskResponse = new VerifyFaceMaskResponse();

			verifyFaceMaskResponse.HttpResponse = context.HttpResponse;
			verifyFaceMaskResponse.RequestId = context.StringValue("VerifyFaceMask.RequestId");

			VerifyFaceMaskResponse.VerifyFaceMask_Data data = new VerifyFaceMaskResponse.VerifyFaceMask_Data();
			data.Confidence = context.FloatValue("VerifyFaceMask.Data.Confidence");
			data.Mask = context.IntegerValue("VerifyFaceMask.Data.Mask");
			data.MaskRef = context.IntegerValue("VerifyFaceMask.Data.MaskRef");

			List<string> data_rectangle = new List<string>();
			for (int i = 0; i < context.Length("VerifyFaceMask.Data.Rectangle.Length"); i++) {
				data_rectangle.Add(context.StringValue("VerifyFaceMask.Data.Rectangle["+ i +"]"));
			}
			data.Rectangle = data_rectangle;

			List<string> data_rectangleRef = new List<string>();
			for (int i = 0; i < context.Length("VerifyFaceMask.Data.RectangleRef.Length"); i++) {
				data_rectangleRef.Add(context.StringValue("VerifyFaceMask.Data.RectangleRef["+ i +"]"));
			}
			data.RectangleRef = data_rectangleRef;

			List<string> data_thresholds = new List<string>();
			for (int i = 0; i < context.Length("VerifyFaceMask.Data.Thresholds.Length"); i++) {
				data_thresholds.Add(context.StringValue("VerifyFaceMask.Data.Thresholds["+ i +"]"));
			}
			data.Thresholds = data_thresholds;
			verifyFaceMaskResponse.Data = data;
        
			return verifyFaceMaskResponse;
        }
    }
}
