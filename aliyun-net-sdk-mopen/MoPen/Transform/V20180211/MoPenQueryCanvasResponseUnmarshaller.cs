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
using Aliyun.Acs.MoPen.Model.V20180211;

namespace Aliyun.Acs.MoPen.Transform.V20180211
{
    public class MoPenQueryCanvasResponseUnmarshaller
    {
        public static MoPenQueryCanvasResponse Unmarshall(UnmarshallerContext context)
        {
			MoPenQueryCanvasResponse moPenQueryCanvasResponse = new MoPenQueryCanvasResponse();

			moPenQueryCanvasResponse.HttpResponse = context.HttpResponse;
			moPenQueryCanvasResponse.RequestId = context.StringValue("MoPenQueryCanvas.RequestId");
			moPenQueryCanvasResponse.Code = context.StringValue("MoPenQueryCanvas.Code");
			moPenQueryCanvasResponse.Message = context.StringValue("MoPenQueryCanvas.Message");
			moPenQueryCanvasResponse.Success = context.BooleanValue("MoPenQueryCanvas.Success");
			moPenQueryCanvasResponse.Description = context.StringValue("MoPenQueryCanvas.Description");

			MoPenQueryCanvasResponse.MoPenQueryCanvas_Data data = new MoPenQueryCanvasResponse.MoPenQueryCanvas_Data();

			List<MoPenQueryCanvasResponse.MoPenQueryCanvas_Data.MoPenQueryCanvas_Canvas> data_canvasList = new List<MoPenQueryCanvasResponse.MoPenQueryCanvas_Data.MoPenQueryCanvas_Canvas>();
			for (int i = 0; i < context.Length("MoPenQueryCanvas.Data.CanvasList.Length"); i++) {
				MoPenQueryCanvasResponse.MoPenQueryCanvas_Data.MoPenQueryCanvas_Canvas canvas = new MoPenQueryCanvasResponse.MoPenQueryCanvas_Data.MoPenQueryCanvas_Canvas();
				canvas.Id = context.LongValue("MoPenQueryCanvas.Data.CanvasList["+ i +"].Id");
				canvas.DeviceName = context.StringValue("MoPenQueryCanvas.Data.CanvasList["+ i +"].DeviceName");
				canvas.Url = context.StringValue("MoPenQueryCanvas.Data.CanvasList["+ i +"].Url");
				canvas.PageId = context.IntegerValue("MoPenQueryCanvas.Data.CanvasList["+ i +"].PageId");
				canvas.SessionId = context.StringValue("MoPenQueryCanvas.Data.CanvasList["+ i +"].SessionId");
				canvas.CreateTime = context.StringValue("MoPenQueryCanvas.Data.CanvasList["+ i +"].CreateTime");
				canvas.LastModified = context.StringValue("MoPenQueryCanvas.Data.CanvasList["+ i +"].LastModified");
				canvas.Status = context.IntegerValue("MoPenQueryCanvas.Data.CanvasList["+ i +"].Status");
				canvas.Attribute = context.StringValue("MoPenQueryCanvas.Data.CanvasList["+ i +"].Attribute");

				data_canvasList.Add(canvas);
			}
			data.CanvasList = data_canvasList;
			moPenQueryCanvasResponse.Data = data;
        
			return moPenQueryCanvasResponse;
        }
    }
}
