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
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class QueryArtExtensionResponseUnmarshaller
    {
        public static QueryArtExtensionResponse Unmarshall(UnmarshallerContext context)
        {
			QueryArtExtensionResponse queryArtExtensionResponse = new QueryArtExtensionResponse();

			queryArtExtensionResponse.HttpResponse = context.HttpResponse;
			queryArtExtensionResponse.RequestId = context.StringValue("QueryArtExtension.RequestId");
			queryArtExtensionResponse.ObjectType = context.StringValue("QueryArtExtension.ObjectType");
			queryArtExtensionResponse.MaterialsAndTechniques = context.StringValue("QueryArtExtension.MaterialsAndTechniques");
			queryArtExtensionResponse.Dimensions = context.StringValue("QueryArtExtension.Dimensions");
			queryArtExtensionResponse.Title = context.StringValue("QueryArtExtension.Title");
			queryArtExtensionResponse.DateOrPeriod = context.StringValue("QueryArtExtension.DateOrPeriod");
			queryArtExtensionResponse.Maker = context.StringValue("QueryArtExtension.Maker");
			queryArtExtensionResponse.InscriptionsAndMarkings = context.StringValue("QueryArtExtension.InscriptionsAndMarkings");
			queryArtExtensionResponse.Subject = context.StringValue("QueryArtExtension.Subject");
			queryArtExtensionResponse.Features = context.StringValue("QueryArtExtension.Features");
			queryArtExtensionResponse.Reference = context.StringValue("QueryArtExtension.Reference");
        
			return queryArtExtensionResponse;
        }
    }
}
