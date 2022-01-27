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
    public class DescribeEsExceptionDataResponseUnmarshaller
    {
        public static DescribeEsExceptionDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEsExceptionDataResponse describeEsExceptionDataResponse = new DescribeEsExceptionDataResponse();

			describeEsExceptionDataResponse.HttpResponse = _ctx.HttpResponse;
			describeEsExceptionDataResponse.RequestId = _ctx.StringValue("DescribeEsExceptionData.RequestId");

			List<DescribeEsExceptionDataResponse.DescribeEsExceptionData_Content> describeEsExceptionDataResponse_contents = new List<DescribeEsExceptionDataResponse.DescribeEsExceptionData_Content>();
			for (int i = 0; i < _ctx.Length("DescribeEsExceptionData.Contents.Length"); i++) {
				DescribeEsExceptionDataResponse.DescribeEsExceptionData_Content content = new DescribeEsExceptionDataResponse.DescribeEsExceptionData_Content();
				content.Name = _ctx.StringValue("DescribeEsExceptionData.Contents["+ i +"].Name");

				List<string> content_columns = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeEsExceptionData.Contents["+ i +"].Columns.Length"); j++) {
					content_columns.Add(_ctx.StringValue("DescribeEsExceptionData.Contents["+ i +"].Columns["+ j +"]"));
				}
				content.Columns = content_columns;

				List<string> content_points = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeEsExceptionData.Contents["+ i +"].Points.Length"); j++) {
					content_points.Add(_ctx.StringValue("DescribeEsExceptionData.Contents["+ i +"].Points["+ j +"]"));
				}
				content.Points = content_points;

				describeEsExceptionDataResponse_contents.Add(content);
			}
			describeEsExceptionDataResponse.Contents = describeEsExceptionDataResponse_contents;
        
			return describeEsExceptionDataResponse;
        }
    }
}
