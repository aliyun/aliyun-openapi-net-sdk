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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeAutomateResponseConfigPlayBooksResponseUnmarshaller
    {
        public static DescribeAutomateResponseConfigPlayBooksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAutomateResponseConfigPlayBooksResponse describeAutomateResponseConfigPlayBooksResponse = new DescribeAutomateResponseConfigPlayBooksResponse();

			describeAutomateResponseConfigPlayBooksResponse.HttpResponse = _ctx.HttpResponse;
			describeAutomateResponseConfigPlayBooksResponse.Success = _ctx.BooleanValue("DescribeAutomateResponseConfigPlayBooks.Success");
			describeAutomateResponseConfigPlayBooksResponse.Code = _ctx.IntegerValue("DescribeAutomateResponseConfigPlayBooks.Code");
			describeAutomateResponseConfigPlayBooksResponse.Message = _ctx.StringValue("DescribeAutomateResponseConfigPlayBooks.Message");
			describeAutomateResponseConfigPlayBooksResponse.RequestId = _ctx.StringValue("DescribeAutomateResponseConfigPlayBooks.RequestId");

			List<DescribeAutomateResponseConfigPlayBooksResponse.DescribeAutomateResponseConfigPlayBooks_DataItem> describeAutomateResponseConfigPlayBooksResponse_data = new List<DescribeAutomateResponseConfigPlayBooksResponse.DescribeAutomateResponseConfigPlayBooks_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeAutomateResponseConfigPlayBooks.Data.Length"); i++) {
				DescribeAutomateResponseConfigPlayBooksResponse.DescribeAutomateResponseConfigPlayBooks_DataItem dataItem = new DescribeAutomateResponseConfigPlayBooksResponse.DescribeAutomateResponseConfigPlayBooks_DataItem();
				dataItem.Uuid = _ctx.StringValue("DescribeAutomateResponseConfigPlayBooks.Data["+ i +"].Uuid");
				dataItem.Description = _ctx.StringValue("DescribeAutomateResponseConfigPlayBooks.Data["+ i +"].Description");
				dataItem.DisplayName = _ctx.StringValue("DescribeAutomateResponseConfigPlayBooks.Data["+ i +"].DisplayName");
				dataItem.Name = _ctx.StringValue("DescribeAutomateResponseConfigPlayBooks.Data["+ i +"].Name");
				dataItem.ParamType = _ctx.StringValue("DescribeAutomateResponseConfigPlayBooks.Data["+ i +"].ParamType");

				describeAutomateResponseConfigPlayBooksResponse_data.Add(dataItem);
			}
			describeAutomateResponseConfigPlayBooksResponse.Data = describeAutomateResponseConfigPlayBooksResponse_data;
        
			return describeAutomateResponseConfigPlayBooksResponse;
        }
    }
}
