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
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class DescribeProjectAttachmentsResponseUnmarshaller
    {
        public static DescribeProjectAttachmentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeProjectAttachmentsResponse describeProjectAttachmentsResponse = new DescribeProjectAttachmentsResponse();

			describeProjectAttachmentsResponse.HttpResponse = _ctx.HttpResponse;
			describeProjectAttachmentsResponse.Success = _ctx.BooleanValue("DescribeProjectAttachments.Success");
			describeProjectAttachmentsResponse.RequestId = _ctx.StringValue("DescribeProjectAttachments.RequestId");

			List<DescribeProjectAttachmentsResponse.DescribeProjectAttachments_ProjectAttachment> describeProjectAttachmentsResponse_result = new List<DescribeProjectAttachmentsResponse.DescribeProjectAttachments_ProjectAttachment>();
			for (int i = 0; i < _ctx.Length("DescribeProjectAttachments.Result.Length"); i++) {
				DescribeProjectAttachmentsResponse.DescribeProjectAttachments_ProjectAttachment projectAttachment = new DescribeProjectAttachmentsResponse.DescribeProjectAttachments_ProjectAttachment();
				projectAttachment.FileLinkGmtExpired = _ctx.LongValue("DescribeProjectAttachments.Result["+ i +"].FileLinkGmtExpired");
				projectAttachment.StepNo = _ctx.IntegerValue("DescribeProjectAttachments.Result["+ i +"].StepNo");
				projectAttachment.AttachmentToken = _ctx.StringValue("DescribeProjectAttachments.Result["+ i +"].AttachmentToken");
				projectAttachment.FileName = _ctx.StringValue("DescribeProjectAttachments.Result["+ i +"].FileName");
				projectAttachment.OperatorRole = _ctx.StringValue("DescribeProjectAttachments.Result["+ i +"].OperatorRole");
				projectAttachment.NodeName = _ctx.StringValue("DescribeProjectAttachments.Result["+ i +"].NodeName");
				projectAttachment.OperatorName = _ctx.StringValue("DescribeProjectAttachments.Result["+ i +"].OperatorName");
				projectAttachment.FileLink = _ctx.StringValue("DescribeProjectAttachments.Result["+ i +"].FileLink");
				projectAttachment.GmtCreate = _ctx.LongValue("DescribeProjectAttachments.Result["+ i +"].GmtCreate");
				projectAttachment.FileSuffix = _ctx.StringValue("DescribeProjectAttachments.Result["+ i +"].FileSuffix");
				projectAttachment._Operator = _ctx.LongValue("DescribeProjectAttachments.Result["+ i +"].Operator");
				projectAttachment.Content = _ctx.StringValue("DescribeProjectAttachments.Result["+ i +"].Content");
				projectAttachment.NodeId = _ctx.LongValue("DescribeProjectAttachments.Result["+ i +"].NodeId");
				projectAttachment.AttachmentType = _ctx.StringValue("DescribeProjectAttachments.Result["+ i +"].AttachmentType");
				projectAttachment.FileSize = _ctx.LongValue("DescribeProjectAttachments.Result["+ i +"].FileSize");

				describeProjectAttachmentsResponse_result.Add(projectAttachment);
			}
			describeProjectAttachmentsResponse.Result = describeProjectAttachmentsResponse_result;
        
			return describeProjectAttachmentsResponse;
        }
    }
}
