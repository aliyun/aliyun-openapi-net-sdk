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
    public class ImportK8sClusterResponseUnmarshaller
    {
        public static ImportK8sClusterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ImportK8sClusterResponse importK8sClusterResponse = new ImportK8sClusterResponse();

			importK8sClusterResponse.HttpResponse = _ctx.HttpResponse;
			importK8sClusterResponse.Code = _ctx.IntegerValue("ImportK8sCluster.Code");
			importK8sClusterResponse.Message = _ctx.StringValue("ImportK8sCluster.Message");
			importK8sClusterResponse.Data = _ctx.StringValue("ImportK8sCluster.Data");
			importK8sClusterResponse.RequestId = _ctx.StringValue("ImportK8sCluster.RequestId");
        
			return importK8sClusterResponse;
        }
    }
}
