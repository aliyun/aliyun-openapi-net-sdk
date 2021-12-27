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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnEsExceptionDataResponseUnmarshaller
    {
        public static DescribeDcdnEsExceptionDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnEsExceptionDataResponse describeDcdnEsExceptionDataResponse = new DescribeDcdnEsExceptionDataResponse();

			describeDcdnEsExceptionDataResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnEsExceptionDataResponse.RequestId = _ctx.StringValue("DescribeDcdnEsExceptionData.RequestId");

			List<DescribeDcdnEsExceptionDataResponse.DescribeDcdnEsExceptionData_Content> describeDcdnEsExceptionDataResponse_contents = new List<DescribeDcdnEsExceptionDataResponse.DescribeDcdnEsExceptionData_Content>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnEsExceptionData.Contents.Length"); i++) {
				DescribeDcdnEsExceptionDataResponse.DescribeDcdnEsExceptionData_Content content = new DescribeDcdnEsExceptionDataResponse.DescribeDcdnEsExceptionData_Content();
				content.Name = _ctx.StringValue("DescribeDcdnEsExceptionData.Contents["+ i +"].Name");

				List<string> content_columns = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDcdnEsExceptionData.Contents["+ i +"].Columns.Length"); j++) {
					content_columns.Add(_ctx.StringValue("DescribeDcdnEsExceptionData.Contents["+ i +"].Columns["+ j +"]"));
				}
				content.Columns = content_columns;

				List<string> content_points = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeDcdnEsExceptionData.Contents["+ i +"].Points.Length"); j++) {
					content_points.Add(_ctx.StringValue("DescribeDcdnEsExceptionData.Contents["+ i +"].Points["+ j +"]"));
				}
				content.Points = content_points;

				describeDcdnEsExceptionDataResponse_contents.Add(content);
			}
			describeDcdnEsExceptionDataResponse.Contents = describeDcdnEsExceptionDataResponse_contents;
        
			return describeDcdnEsExceptionDataResponse;
        }
    }
}
