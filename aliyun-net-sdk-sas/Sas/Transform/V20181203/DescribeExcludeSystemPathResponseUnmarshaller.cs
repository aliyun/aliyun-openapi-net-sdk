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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeExcludeSystemPathResponseUnmarshaller
    {
        public static DescribeExcludeSystemPathResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeExcludeSystemPathResponse describeExcludeSystemPathResponse = new DescribeExcludeSystemPathResponse();

			describeExcludeSystemPathResponse.HttpResponse = _ctx.HttpResponse;
			describeExcludeSystemPathResponse.RequestId = _ctx.StringValue("DescribeExcludeSystemPath.RequestId");

			DescribeExcludeSystemPathResponse.DescribeExcludeSystemPath_PageInfo pageInfo = new DescribeExcludeSystemPathResponse.DescribeExcludeSystemPath_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribeExcludeSystemPath.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeExcludeSystemPath.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeExcludeSystemPath.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeExcludeSystemPath.PageInfo.CurrentPage");
			describeExcludeSystemPathResponse.PageInfo = pageInfo;

			List<DescribeExcludeSystemPathResponse.DescribeExcludeSystemPath_BaseModelDTO> describeExcludeSystemPathResponse_excludePaths = new List<DescribeExcludeSystemPathResponse.DescribeExcludeSystemPath_BaseModelDTO>();
			for (int i = 0; i < _ctx.Length("DescribeExcludeSystemPath.ExcludePaths.Length"); i++) {
				DescribeExcludeSystemPathResponse.DescribeExcludeSystemPath_BaseModelDTO baseModelDTO = new DescribeExcludeSystemPathResponse.DescribeExcludeSystemPath_BaseModelDTO();
				baseModelDTO.Id = _ctx.LongValue("DescribeExcludeSystemPath.ExcludePaths["+ i +"].Id");
				baseModelDTO.Os = _ctx.StringValue("DescribeExcludeSystemPath.ExcludePaths["+ i +"].Os");
				baseModelDTO.Path = _ctx.StringValue("DescribeExcludeSystemPath.ExcludePaths["+ i +"].Path");

				describeExcludeSystemPathResponse_excludePaths.Add(baseModelDTO);
			}
			describeExcludeSystemPathResponse.ExcludePaths = describeExcludeSystemPathResponse_excludePaths;
        
			return describeExcludeSystemPathResponse;
        }
    }
}
