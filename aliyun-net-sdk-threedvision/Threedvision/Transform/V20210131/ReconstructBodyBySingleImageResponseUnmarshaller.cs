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
using Aliyun.Acs.threedvision.Model.V20210131;

namespace Aliyun.Acs.threedvision.Transform.V20210131
{
    public class ReconstructBodyBySingleImageResponseUnmarshaller
    {
        public static ReconstructBodyBySingleImageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ReconstructBodyBySingleImageResponse reconstructBodyBySingleImageResponse = new ReconstructBodyBySingleImageResponse();

			reconstructBodyBySingleImageResponse.HttpResponse = _ctx.HttpResponse;
			reconstructBodyBySingleImageResponse.RequestId = _ctx.StringValue("ReconstructBodyBySingleImage.RequestId");
			reconstructBodyBySingleImageResponse.Code = _ctx.StringValue("ReconstructBodyBySingleImage.Code");
			reconstructBodyBySingleImageResponse.Message = _ctx.StringValue("ReconstructBodyBySingleImage.Message");

			ReconstructBodyBySingleImageResponse.ReconstructBodyBySingleImage_Data data = new ReconstructBodyBySingleImageResponse.ReconstructBodyBySingleImage_Data();
			data.DepthURL = _ctx.StringValue("ReconstructBodyBySingleImage.Data.DepthURL");
			data.MeshURL = _ctx.StringValue("ReconstructBodyBySingleImage.Data.MeshURL");
			reconstructBodyBySingleImageResponse.Data = data;
        
			return reconstructBodyBySingleImageResponse;
        }
    }
}
