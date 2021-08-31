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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class QueryK8sClusterLogProjectInfoResponseUnmarshaller
    {
        public static QueryK8sClusterLogProjectInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryK8sClusterLogProjectInfoResponse queryK8sClusterLogProjectInfoResponse = new QueryK8sClusterLogProjectInfoResponse();

			queryK8sClusterLogProjectInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryK8sClusterLogProjectInfoResponse.RequestId = _ctx.StringValue("QueryK8sClusterLogProjectInfo.RequestId");
			queryK8sClusterLogProjectInfoResponse.Code = _ctx.IntegerValue("QueryK8sClusterLogProjectInfo.Code");
			queryK8sClusterLogProjectInfoResponse.Message = _ctx.StringValue("QueryK8sClusterLogProjectInfo.Message");

			QueryK8sClusterLogProjectInfoResponse.QueryK8sClusterLogProjectInfo_ProjectInfo projectInfo = new QueryK8sClusterLogProjectInfoResponse.QueryK8sClusterLogProjectInfo_ProjectInfo();
			projectInfo.ProjectName = _ctx.StringValue("QueryK8sClusterLogProjectInfo.ProjectInfo.ProjectName");
			queryK8sClusterLogProjectInfoResponse.ProjectInfo = projectInfo;
        
			return queryK8sClusterLogProjectInfoResponse;
        }
    }
}
