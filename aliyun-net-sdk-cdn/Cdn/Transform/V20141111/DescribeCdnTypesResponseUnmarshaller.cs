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
using Aliyun.Acs.Cdn.Model.V20141111;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeCdnTypesResponseUnmarshaller
    {
        public static DescribeCdnTypesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCdnTypesResponse describeCdnTypesResponse = new DescribeCdnTypesResponse();

			describeCdnTypesResponse.HttpResponse = _ctx.HttpResponse;
			describeCdnTypesResponse.RequestId = _ctx.StringValue("DescribeCdnTypes.RequestId");

			List<DescribeCdnTypesResponse.DescribeCdnTypes_CdnType> describeCdnTypesResponse_cdnTypes = new List<DescribeCdnTypesResponse.DescribeCdnTypes_CdnType>();
			for (int i = 0; i < _ctx.Length("DescribeCdnTypes.CdnTypes.Length"); i++) {
				DescribeCdnTypesResponse.DescribeCdnTypes_CdnType cdnType = new DescribeCdnTypesResponse.DescribeCdnTypes_CdnType();
				cdnType.Type = _ctx.StringValue("DescribeCdnTypes.CdnTypes["+ i +"].Type");
				cdnType.Desc = _ctx.StringValue("DescribeCdnTypes.CdnTypes["+ i +"].Desc");

				describeCdnTypesResponse_cdnTypes.Add(cdnType);
			}
			describeCdnTypesResponse.CdnTypes = describeCdnTypesResponse_cdnTypes;
        
			return describeCdnTypesResponse;
        }
    }
}
