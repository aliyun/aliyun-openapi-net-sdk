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
    public class ReconstructThreeDMultiViewResponseUnmarshaller
    {
        public static ReconstructThreeDMultiViewResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ReconstructThreeDMultiViewResponse reconstructThreeDMultiViewResponse = new ReconstructThreeDMultiViewResponse();

			reconstructThreeDMultiViewResponse.HttpResponse = _ctx.HttpResponse;
			reconstructThreeDMultiViewResponse.RequestId = _ctx.StringValue("ReconstructThreeDMultiView.RequestId");
			reconstructThreeDMultiViewResponse.Code = _ctx.StringValue("ReconstructThreeDMultiView.Code");
			reconstructThreeDMultiViewResponse.Message = _ctx.StringValue("ReconstructThreeDMultiView.Message");

			ReconstructThreeDMultiViewResponse.ReconstructThreeDMultiView_Data data = new ReconstructThreeDMultiViewResponse.ReconstructThreeDMultiView_Data();
			data.PointCloudURL = _ctx.StringValue("ReconstructThreeDMultiView.Data.PointCloudURL");
			reconstructThreeDMultiViewResponse.Data = data;
        
			return reconstructThreeDMultiViewResponse;
        }
    }
}
