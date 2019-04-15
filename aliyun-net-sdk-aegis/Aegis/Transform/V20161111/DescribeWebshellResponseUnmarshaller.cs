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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeWebshellResponseUnmarshaller
    {
        public static DescribeWebshellResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeWebshellResponse describeWebshellResponse = new DescribeWebshellResponse();

			describeWebshellResponse.HttpResponse = context.HttpResponse;
			describeWebshellResponse.RequestId = context.StringValue("DescribeWebshell.RequestId");

			List<DescribeWebshellResponse.DescribeWebshell_WebshellListItem> describeWebshellResponse_webshellList = new List<DescribeWebshellResponse.DescribeWebshell_WebshellListItem>();
			for (int i = 0; i < context.Length("DescribeWebshell.WebshellList.Length"); i++) {
				DescribeWebshellResponse.DescribeWebshell_WebshellListItem webshellListItem = new DescribeWebshellResponse.DescribeWebshell_WebshellListItem();
				webshellListItem.Os = context.StringValue("DescribeWebshell.WebshellList["+ i +"].Os");
				webshellListItem.InstanceName = context.StringValue("DescribeWebshell.WebshellList["+ i +"].InstanceName");
				webshellListItem.GroupId = context.LongValue("DescribeWebshell.WebshellList["+ i +"].GroupId");
				webshellListItem.Ip = context.StringValue("DescribeWebshell.WebshellList["+ i +"].Ip");
				webshellListItem.Uuid = context.StringValue("DescribeWebshell.WebshellList["+ i +"].Uuid");
				webshellListItem.FoundTime = context.StringValue("DescribeWebshell.WebshellList["+ i +"].FoundTime");
				webshellListItem.InstanceId = context.StringValue("DescribeWebshell.WebshellList["+ i +"].InstanceId");
				webshellListItem.TrojanType = context.StringValue("DescribeWebshell.WebshellList["+ i +"].TrojanType");
				webshellListItem.FirstFoundTime = context.StringValue("DescribeWebshell.WebshellList["+ i +"].FirstFoundTime");
				webshellListItem.TrojanSize = context.LongValue("DescribeWebshell.WebshellList["+ i +"].TrojanSize");
				webshellListItem.Domain = context.StringValue("DescribeWebshell.WebshellList["+ i +"].Domain");
				webshellListItem.TrojanPath = context.StringValue("DescribeWebshell.WebshellList["+ i +"].TrojanPath");
				webshellListItem.Region = context.StringValue("DescribeWebshell.WebshellList["+ i +"].Region");
				webshellListItem.Status = context.IntegerValue("DescribeWebshell.WebshellList["+ i +"].Status");

				describeWebshellResponse_webshellList.Add(webshellListItem);
			}
			describeWebshellResponse.WebshellList = describeWebshellResponse_webshellList;
        
			return describeWebshellResponse;
        }
    }
}
