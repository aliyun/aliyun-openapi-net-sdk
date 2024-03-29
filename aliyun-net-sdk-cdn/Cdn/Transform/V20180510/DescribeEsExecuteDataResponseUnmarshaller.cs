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
    public class DescribeEsExecuteDataResponseUnmarshaller
    {
        public static DescribeEsExecuteDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEsExecuteDataResponse describeEsExecuteDataResponse = new DescribeEsExecuteDataResponse();

			describeEsExecuteDataResponse.HttpResponse = _ctx.HttpResponse;
			describeEsExecuteDataResponse.RequestId = _ctx.StringValue("DescribeEsExecuteData.RequestId");

			List<DescribeEsExecuteDataResponse.DescribeEsExecuteData_Content> describeEsExecuteDataResponse_contents = new List<DescribeEsExecuteDataResponse.DescribeEsExecuteData_Content>();
			for (int i = 0; i < _ctx.Length("DescribeEsExecuteData.Contents.Length"); i++) {
				DescribeEsExecuteDataResponse.DescribeEsExecuteData_Content content = new DescribeEsExecuteDataResponse.DescribeEsExecuteData_Content();
				content.Name = _ctx.StringValue("DescribeEsExecuteData.Contents["+ i +"].Name");

				List<string> content_points = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeEsExecuteData.Contents["+ i +"].Points.Length"); j++) {
					content_points.Add(_ctx.StringValue("DescribeEsExecuteData.Contents["+ i +"].Points["+ j +"]"));
				}
				content.Points = content_points;

				List<string> content_columns = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeEsExecuteData.Contents["+ i +"].Columns.Length"); j++) {
					content_columns.Add(_ctx.StringValue("DescribeEsExecuteData.Contents["+ i +"].Columns["+ j +"]"));
				}
				content.Columns = content_columns;

				describeEsExecuteDataResponse_contents.Add(content);
			}
			describeEsExecuteDataResponse.Contents = describeEsExecuteDataResponse_contents;
        
			return describeEsExecuteDataResponse;
        }
    }
}
