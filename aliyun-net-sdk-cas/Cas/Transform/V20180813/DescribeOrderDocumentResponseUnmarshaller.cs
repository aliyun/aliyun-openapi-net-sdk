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
using Aliyun.Acs.cas.Model.V20180813;

namespace Aliyun.Acs.cas.Transform.V20180813
{
    public class DescribeOrderDocumentResponseUnmarshaller
    {
        public static DescribeOrderDocumentResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrderDocumentResponse describeOrderDocumentResponse = new DescribeOrderDocumentResponse();

			describeOrderDocumentResponse.HttpResponse = context.HttpResponse;
			describeOrderDocumentResponse.RequestId = context.StringValue("DescribeOrderDocument.RequestId");

			List<DescribeOrderDocumentResponse.DescribeOrderDocument_OrderDocument> describeOrderDocumentResponse_orderDocumentList = new List<DescribeOrderDocumentResponse.DescribeOrderDocument_OrderDocument>();
			for (int i = 0; i < context.Length("DescribeOrderDocument.OrderDocumentList.Length"); i++) {
				DescribeOrderDocumentResponse.DescribeOrderDocument_OrderDocument orderDocument = new DescribeOrderDocumentResponse.DescribeOrderDocument_OrderDocument();
				orderDocument.DocumentType = context.IntegerValue("DescribeOrderDocument.OrderDocumentList["+ i +"].DocumentType");
				orderDocument.TplDocNote = context.StringValue("DescribeOrderDocument.OrderDocumentList["+ i +"].TplDocNote");
				orderDocument.TplDocOssKey = context.StringValue("DescribeOrderDocument.OrderDocumentList["+ i +"].TplDocOssKey");
				orderDocument.OrderDocOssKey = context.StringValue("DescribeOrderDocument.OrderDocumentList["+ i +"].OrderDocOssKey");
				orderDocument.OrderDocDate = context.LongValue("DescribeOrderDocument.OrderDocumentList["+ i +"].OrderDocDate");
				orderDocument.OrderDocExt = context.StringValue("DescribeOrderDocument.OrderDocumentList["+ i +"].OrderDocExt");

				describeOrderDocumentResponse_orderDocumentList.Add(orderDocument);
			}
			describeOrderDocumentResponse.OrderDocumentList = describeOrderDocumentResponse_orderDocumentList;
        
			return describeOrderDocumentResponse;
        }
    }
}
