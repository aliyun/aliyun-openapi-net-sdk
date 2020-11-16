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
using Aliyun.Acs.objectdet.Model.V20191230;

namespace Aliyun.Acs.objectdet.Transform.V20191230
{
    public class DetectMainBodyResponseUnmarshaller
    {
        public static DetectMainBodyResponse Unmarshall(UnmarshallerContext context)
        {
			DetectMainBodyResponse detectMainBodyResponse = new DetectMainBodyResponse();

			detectMainBodyResponse.HttpResponse = context.HttpResponse;
			detectMainBodyResponse.RequestId = context.StringValue("DetectMainBody.RequestId");

			DetectMainBodyResponse.DetectMainBody_Data data = new DetectMainBodyResponse.DetectMainBody_Data();

			DetectMainBodyResponse.DetectMainBody_Data.DetectMainBody_Location location = new DetectMainBodyResponse.DetectMainBody_Data.DetectMainBody_Location();
			location.X = context.IntegerValue("DetectMainBody.Data.Location.X");
			location.Y = context.IntegerValue("DetectMainBody.Data.Location.Y");
			location.Width = context.IntegerValue("DetectMainBody.Data.Location.Width");
			location.Height = context.IntegerValue("DetectMainBody.Data.Location.Height");
			data.Location = location;
			detectMainBodyResponse.Data = data;
        
			return detectMainBodyResponse;
        }
    }
}
