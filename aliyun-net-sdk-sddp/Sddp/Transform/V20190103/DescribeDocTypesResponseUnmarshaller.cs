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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeDocTypesResponseUnmarshaller
    {
        public static DescribeDocTypesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDocTypesResponse describeDocTypesResponse = new DescribeDocTypesResponse();

			describeDocTypesResponse.HttpResponse = _ctx.HttpResponse;
			describeDocTypesResponse.RequestId = _ctx.StringValue("DescribeDocTypes.RequestId");

			List<DescribeDocTypesResponse.DescribeDocTypes_DocType> describeDocTypesResponse_docTypeList = new List<DescribeDocTypesResponse.DescribeDocTypes_DocType>();
			for (int i = 0; i < _ctx.Length("DescribeDocTypes.DocTypeList.Length"); i++) {
				DescribeDocTypesResponse.DescribeDocTypes_DocType docType = new DescribeDocTypesResponse.DescribeDocTypes_DocType();
				docType.Code = _ctx.LongValue("DescribeDocTypes.DocTypeList["+ i +"].Code");
				docType.Name = _ctx.StringValue("DescribeDocTypes.DocTypeList["+ i +"].Name");
				docType.Id = _ctx.LongValue("DescribeDocTypes.DocTypeList["+ i +"].Id");

				describeDocTypesResponse_docTypeList.Add(docType);
			}
			describeDocTypesResponse.DocTypeList = describeDocTypesResponse_docTypeList;
        
			return describeDocTypesResponse;
        }
    }
}
