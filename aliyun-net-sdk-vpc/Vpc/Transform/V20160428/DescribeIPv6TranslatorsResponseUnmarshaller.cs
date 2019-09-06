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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeIPv6TranslatorsResponseUnmarshaller
    {
        public static DescribeIPv6TranslatorsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIPv6TranslatorsResponse describeIPv6TranslatorsResponse = new DescribeIPv6TranslatorsResponse();

			describeIPv6TranslatorsResponse.HttpResponse = context.HttpResponse;
			describeIPv6TranslatorsResponse.RequestId = context.StringValue("DescribeIPv6Translators.RequestId");
			describeIPv6TranslatorsResponse.TotalCount = context.IntegerValue("DescribeIPv6Translators.TotalCount");
			describeIPv6TranslatorsResponse.PageNumber = context.IntegerValue("DescribeIPv6Translators.PageNumber");
			describeIPv6TranslatorsResponse.PageSize = context.IntegerValue("DescribeIPv6Translators.PageSize");

			List<DescribeIPv6TranslatorsResponse.DescribeIPv6Translators_Ipv6Translator> describeIPv6TranslatorsResponse_ipv6Translators = new List<DescribeIPv6TranslatorsResponse.DescribeIPv6Translators_Ipv6Translator>();
			for (int i = 0; i < context.Length("DescribeIPv6Translators.Ipv6Translators.Length"); i++) {
				DescribeIPv6TranslatorsResponse.DescribeIPv6Translators_Ipv6Translator ipv6Translator = new DescribeIPv6TranslatorsResponse.DescribeIPv6Translators_Ipv6Translator();
				ipv6Translator.Ipv6TranslatorId = context.StringValue("DescribeIPv6Translators.Ipv6Translators["+ i +"].Ipv6TranslatorId");
				ipv6Translator.CreateTime = context.LongValue("DescribeIPv6Translators.Ipv6Translators["+ i +"].CreateTime");
				ipv6Translator.EndTime = context.LongValue("DescribeIPv6Translators.Ipv6Translators["+ i +"].EndTime");
				ipv6Translator.Spec = context.StringValue("DescribeIPv6Translators.Ipv6Translators["+ i +"].Spec");
				ipv6Translator.Name = context.StringValue("DescribeIPv6Translators.Ipv6Translators["+ i +"].Name");
				ipv6Translator.Description = context.StringValue("DescribeIPv6Translators.Ipv6Translators["+ i +"].Description");
				ipv6Translator.Status = context.StringValue("DescribeIPv6Translators.Ipv6Translators["+ i +"].Status");
				ipv6Translator.BusinessStatus = context.StringValue("DescribeIPv6Translators.Ipv6Translators["+ i +"].BusinessStatus");
				ipv6Translator.PayType = context.StringValue("DescribeIPv6Translators.Ipv6Translators["+ i +"].PayType");
				ipv6Translator.Bandwidth = context.IntegerValue("DescribeIPv6Translators.Ipv6Translators["+ i +"].Bandwidth");
				ipv6Translator.AllocateIpv6Addr = context.StringValue("DescribeIPv6Translators.Ipv6Translators["+ i +"].AllocateIpv6Addr");
				ipv6Translator.AllocateIpv4Addr = context.StringValue("DescribeIPv6Translators.Ipv6Translators["+ i +"].AllocateIpv4Addr");
				ipv6Translator.AvailableBandwidth = context.StringValue("DescribeIPv6Translators.Ipv6Translators["+ i +"].AvailableBandwidth");
				ipv6Translator.RegionId = context.StringValue("DescribeIPv6Translators.Ipv6Translators["+ i +"].RegionId");

				List<string> ipv6Translator_ipv6TranslatorEntryIds = new List<string>();
				for (int j = 0; j < context.Length("DescribeIPv6Translators.Ipv6Translators["+ i +"].Ipv6TranslatorEntryIds.Length"); j++) {
					ipv6Translator_ipv6TranslatorEntryIds.Add(context.StringValue("DescribeIPv6Translators.Ipv6Translators["+ i +"].Ipv6TranslatorEntryIds["+ j +"]"));
				}
				ipv6Translator.Ipv6TranslatorEntryIds = ipv6Translator_ipv6TranslatorEntryIds;

				describeIPv6TranslatorsResponse_ipv6Translators.Add(ipv6Translator);
			}
			describeIPv6TranslatorsResponse.Ipv6Translators = describeIPv6TranslatorsResponse_ipv6Translators;
        
			return describeIPv6TranslatorsResponse;
        }
    }
}
