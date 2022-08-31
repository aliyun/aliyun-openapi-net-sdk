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
using Aliyun.Acs.Cdn.Model.V20180510;

namespace Aliyun.Acs.Cdn.Transform.V20180510
{
    public class BatchSetCdnDomainConfigResponseUnmarshaller
    {
        public static BatchSetCdnDomainConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchSetCdnDomainConfigResponse batchSetCdnDomainConfigResponse = new BatchSetCdnDomainConfigResponse();

			batchSetCdnDomainConfigResponse.HttpResponse = _ctx.HttpResponse;
			batchSetCdnDomainConfigResponse.RequestId = _ctx.StringValue("BatchSetCdnDomainConfig.RequestId");

			List<BatchSetCdnDomainConfigResponse.BatchSetCdnDomainConfig_DomainConfigModel> batchSetCdnDomainConfigResponse_domainConfigList = new List<BatchSetCdnDomainConfigResponse.BatchSetCdnDomainConfig_DomainConfigModel>();
			for (int i = 0; i < _ctx.Length("BatchSetCdnDomainConfig.DomainConfigList.Length"); i++) {
				BatchSetCdnDomainConfigResponse.BatchSetCdnDomainConfig_DomainConfigModel domainConfigModel = new BatchSetCdnDomainConfigResponse.BatchSetCdnDomainConfig_DomainConfigModel();
				domainConfigModel.ConfigId = _ctx.LongValue("BatchSetCdnDomainConfig.DomainConfigList["+ i +"].ConfigId");
				domainConfigModel.DomainName = _ctx.StringValue("BatchSetCdnDomainConfig.DomainConfigList["+ i +"].DomainName");
				domainConfigModel.FunctionName = _ctx.StringValue("BatchSetCdnDomainConfig.DomainConfigList["+ i +"].FunctionName");

				batchSetCdnDomainConfigResponse_domainConfigList.Add(domainConfigModel);
			}
			batchSetCdnDomainConfigResponse.DomainConfigList = batchSetCdnDomainConfigResponse_domainConfigList;
        
			return batchSetCdnDomainConfigResponse;
        }
    }
}
