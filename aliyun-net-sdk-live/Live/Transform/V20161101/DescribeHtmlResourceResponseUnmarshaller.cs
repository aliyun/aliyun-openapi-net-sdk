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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeHtmlResourceResponseUnmarshaller
    {
        public static DescribeHtmlResourceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeHtmlResourceResponse describeHtmlResourceResponse = new DescribeHtmlResourceResponse();

			describeHtmlResourceResponse.HttpResponse = context.HttpResponse;
			describeHtmlResourceResponse.RequestId = context.StringValue("DescribeHtmlResource.RequestId");

			DescribeHtmlResourceResponse.DescribeHtmlResource_HtmlResource htmlResource = new DescribeHtmlResourceResponse.DescribeHtmlResource_HtmlResource();
			htmlResource.HtmlResourceId = context.StringValue("DescribeHtmlResource.HtmlResource.HtmlResourceId");
			htmlResource.HtmlUrl = context.StringValue("DescribeHtmlResource.HtmlResource.HtmlUrl");
			htmlResource.HtmlContent = context.StringValue("DescribeHtmlResource.HtmlResource.HtmlContent");
			htmlResource.CasterId = context.StringValue("DescribeHtmlResource.HtmlResource.CasterId");
			htmlResource.Config = context.StringValue("DescribeHtmlResource.HtmlResource.Config");
			htmlResource.StreamId = context.StringValue("DescribeHtmlResource.HtmlResource.StreamId");
			describeHtmlResourceResponse.HtmlResource = htmlResource;
        
			return describeHtmlResourceResponse;
        }
    }
}
