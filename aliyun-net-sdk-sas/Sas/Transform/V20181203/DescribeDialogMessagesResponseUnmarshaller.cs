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
    public class DescribeDialogMessagesResponseUnmarshaller
    {
        public static DescribeDialogMessagesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDialogMessagesResponse describeDialogMessagesResponse = new DescribeDialogMessagesResponse();

			describeDialogMessagesResponse.HttpResponse = context.HttpResponse;
			describeDialogMessagesResponse.RequestId = context.StringValue("DescribeDialogMessages.RequestId");
			describeDialogMessagesResponse.TotalCount = context.IntegerValue("DescribeDialogMessages.TotalCount");

			List<DescribeDialogMessagesResponse.DescribeDialogMessages_AegisDynamicDialogDTO> describeDialogMessagesResponse_dialogList = new List<DescribeDialogMessagesResponse.DescribeDialogMessages_AegisDynamicDialogDTO>();
			for (int i = 0; i < context.Length("DescribeDialogMessages.DialogList.Length"); i++) {
				DescribeDialogMessagesResponse.DescribeDialogMessages_AegisDynamicDialogDTO aegisDynamicDialogDTO = new DescribeDialogMessagesResponse.DescribeDialogMessages_AegisDynamicDialogDTO();
				aegisDynamicDialogDTO.ID = context.LongValue("DescribeDialogMessages.DialogList["+ i +"].ID");
				aegisDynamicDialogDTO.DialogKey = context.StringValue("DescribeDialogMessages.DialogList["+ i +"].DialogKey");
				aegisDynamicDialogDTO._Params = context.StringValue("DescribeDialogMessages.DialogList["+ i +"].Params");

				describeDialogMessagesResponse_dialogList.Add(aegisDynamicDialogDTO);
			}
			describeDialogMessagesResponse.DialogList = describeDialogMessagesResponse_dialogList;
        
			return describeDialogMessagesResponse;
        }
    }
}
