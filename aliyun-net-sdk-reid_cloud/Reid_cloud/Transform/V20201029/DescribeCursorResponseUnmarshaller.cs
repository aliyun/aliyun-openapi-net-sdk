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
using Aliyun.Acs.reid_cloud.Model.V20201029;

namespace Aliyun.Acs.reid_cloud.Transform.V20201029
{
    public class DescribeCursorResponseUnmarshaller
    {
        public static DescribeCursorResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCursorResponse describeCursorResponse = new DescribeCursorResponse();

			describeCursorResponse.HttpResponse = _ctx.HttpResponse;
			describeCursorResponse.ErrorCode = _ctx.StringValue("DescribeCursor.ErrorCode");
			describeCursorResponse.ErrorMessage = _ctx.StringValue("DescribeCursor.ErrorMessage");
			describeCursorResponse.Cursor = _ctx.StringValue("DescribeCursor.Cursor");
			describeCursorResponse.Message = _ctx.StringValue("DescribeCursor.Message");
			describeCursorResponse.Code = _ctx.StringValue("DescribeCursor.Code");
			describeCursorResponse.DynamicCode = _ctx.StringValue("DescribeCursor.DynamicCode");
			describeCursorResponse.RequestId = _ctx.StringValue("DescribeCursor.RequestId");
			describeCursorResponse.Success = _ctx.BooleanValue("DescribeCursor.Success");
			describeCursorResponse.DynamicMessage = _ctx.StringValue("DescribeCursor.DynamicMessage");
        
			return describeCursorResponse;
        }
    }
}
