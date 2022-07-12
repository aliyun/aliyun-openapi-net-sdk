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
using Aliyun.Acs.antiddos_public.Model.V20170518;

namespace Aliyun.Acs.antiddos_public.Transform.V20170518
{
    public class DescribeBgpPackByIpResponseUnmarshaller
    {
        public static DescribeBgpPackByIpResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBgpPackByIpResponse describeBgpPackByIpResponse = new DescribeBgpPackByIpResponse();

			describeBgpPackByIpResponse.HttpResponse = _ctx.HttpResponse;
			describeBgpPackByIpResponse.RequestId = _ctx.StringValue("DescribeBgpPackByIp.RequestId");
			describeBgpPackByIpResponse.Code = _ctx.IntegerValue("DescribeBgpPackByIp.Code");
			describeBgpPackByIpResponse.Success = _ctx.BooleanValue("DescribeBgpPackByIp.Success");

			DescribeBgpPackByIpResponse.DescribeBgpPackByIp_DdosbgpInfo ddosbgpInfo = new DescribeBgpPackByIpResponse.DescribeBgpPackByIp_DdosbgpInfo();
			ddosbgpInfo.Ip = _ctx.StringValue("DescribeBgpPackByIp.DdosbgpInfo.Ip");
			ddosbgpInfo.ExpireTime = _ctx.LongValue("DescribeBgpPackByIp.DdosbgpInfo.ExpireTime");
			ddosbgpInfo.ElasticThreshold = _ctx.IntegerValue("DescribeBgpPackByIp.DdosbgpInfo.ElasticThreshold");
			ddosbgpInfo.BaseThreshold = _ctx.IntegerValue("DescribeBgpPackByIp.DdosbgpInfo.BaseThreshold");
			ddosbgpInfo.DdosbgpInstanceId = _ctx.StringValue("DescribeBgpPackByIp.DdosbgpInfo.DdosbgpInstanceId");
			describeBgpPackByIpResponse.DdosbgpInfo = ddosbgpInfo;
        
			return describeBgpPackByIpResponse;
        }
    }
}
