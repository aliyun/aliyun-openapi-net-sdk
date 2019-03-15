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
using Aliyun.Acs.openanalytics.Model.V20180301;

namespace Aliyun.Acs.openanalytics.Transform.V20180301
{
    public class GetEndPointByDomainResponseUnmarshaller
    {
        public static GetEndPointByDomainResponse Unmarshall(UnmarshallerContext context)
        {
			GetEndPointByDomainResponse getEndPointByDomainResponse = new GetEndPointByDomainResponse();

			getEndPointByDomainResponse.HttpResponse = context.HttpResponse;
			getEndPointByDomainResponse.RequestId = context.StringValue("GetEndPointByDomain.RequestId");
			getEndPointByDomainResponse.RegionId = context.StringValue("GetEndPointByDomain.RegionId");

			GetEndPointByDomainResponse.GetEndPointByDomain_EndPointInfo endPointInfo = new GetEndPointByDomainResponse.GetEndPointByDomain_EndPointInfo();
			endPointInfo.EndPointID = context.StringValue("GetEndPointByDomain.EndPointInfo.EndPointID");
			endPointInfo.DomainURL = context.StringValue("GetEndPointByDomain.EndPointInfo.DomainURL");
			endPointInfo.Host = context.StringValue("GetEndPointByDomain.EndPointInfo.Host");
			endPointInfo.Port = context.StringValue("GetEndPointByDomain.EndPointInfo.Port");
			endPointInfo.NetworkType = context.StringValue("GetEndPointByDomain.EndPointInfo.NetworkType");
			endPointInfo.VpcID = context.StringValue("GetEndPointByDomain.EndPointInfo.VpcID");
			endPointInfo.VSwitch = context.StringValue("GetEndPointByDomain.EndPointInfo.VSwitch");
			endPointInfo.Zone = context.StringValue("GetEndPointByDomain.EndPointInfo.Zone");
			endPointInfo.AllowIP = context.StringValue("GetEndPointByDomain.EndPointInfo.AllowIP");
			endPointInfo.CloudInstanceID = context.StringValue("GetEndPointByDomain.EndPointInfo.CloudInstanceID");
			getEndPointByDomainResponse.EndPointInfo = endPointInfo;
        
			return getEndPointByDomainResponse;
        }
    }
}
