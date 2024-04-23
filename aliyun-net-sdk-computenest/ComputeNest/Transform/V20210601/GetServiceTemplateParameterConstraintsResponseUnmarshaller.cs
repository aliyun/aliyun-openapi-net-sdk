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
using Aliyun.Acs.ComputeNest.Model.V20210601;

namespace Aliyun.Acs.ComputeNest.Transform.V20210601
{
    public class GetServiceTemplateParameterConstraintsResponseUnmarshaller
    {
        public static GetServiceTemplateParameterConstraintsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetServiceTemplateParameterConstraintsResponse getServiceTemplateParameterConstraintsResponse = new GetServiceTemplateParameterConstraintsResponse();

			getServiceTemplateParameterConstraintsResponse.HttpResponse = _ctx.HttpResponse;
			getServiceTemplateParameterConstraintsResponse.RequestId = _ctx.StringValue("GetServiceTemplateParameterConstraints.RequestId");

			List<string> getServiceTemplateParameterConstraintsResponse_familyConstraints = new List<string>();
			for (int i = 0; i < _ctx.Length("GetServiceTemplateParameterConstraints.FamilyConstraints.Length"); i++) {
				getServiceTemplateParameterConstraintsResponse_familyConstraints.Add(_ctx.StringValue("GetServiceTemplateParameterConstraints.FamilyConstraints["+ i +"]"));
			}
			getServiceTemplateParameterConstraintsResponse.FamilyConstraints = getServiceTemplateParameterConstraintsResponse_familyConstraints;

			List<GetServiceTemplateParameterConstraintsResponse.GetServiceTemplateParameterConstraints_ParameterConstraintsItem> getServiceTemplateParameterConstraintsResponse_parameterConstraints = new List<GetServiceTemplateParameterConstraintsResponse.GetServiceTemplateParameterConstraints_ParameterConstraintsItem>();
			for (int i = 0; i < _ctx.Length("GetServiceTemplateParameterConstraints.ParameterConstraints.Length"); i++) {
				GetServiceTemplateParameterConstraintsResponse.GetServiceTemplateParameterConstraints_ParameterConstraintsItem parameterConstraintsItem = new GetServiceTemplateParameterConstraintsResponse.GetServiceTemplateParameterConstraints_ParameterConstraintsItem();
				parameterConstraintsItem.Type = _ctx.StringValue("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].Type");
				parameterConstraintsItem.ParameterKey = _ctx.StringValue("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].ParameterKey");
				parameterConstraintsItem.Behavior = _ctx.StringValue("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].Behavior");
				parameterConstraintsItem.BehaviorReason = _ctx.StringValue("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].BehaviorReason");

				List<string> parameterConstraintsItem_allowedValues = new List<string>();
				for (int j = 0; j < _ctx.Length("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].AllowedValues.Length"); j++) {
					parameterConstraintsItem_allowedValues.Add(_ctx.StringValue("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].AllowedValues["+ j +"]"));
				}
				parameterConstraintsItem.AllowedValues = parameterConstraintsItem_allowedValues;

				List<string> parameterConstraintsItem_associationParameterNames = new List<string>();
				for (int j = 0; j < _ctx.Length("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].AssociationParameterNames.Length"); j++) {
					parameterConstraintsItem_associationParameterNames.Add(_ctx.StringValue("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].AssociationParameterNames["+ j +"]"));
				}
				parameterConstraintsItem.AssociationParameterNames = parameterConstraintsItem_associationParameterNames;

				List<GetServiceTemplateParameterConstraintsResponse.GetServiceTemplateParameterConstraints_ParameterConstraintsItem.GetServiceTemplateParameterConstraints_OriginalConstraintsItem> parameterConstraintsItem_originalConstraints = new List<GetServiceTemplateParameterConstraintsResponse.GetServiceTemplateParameterConstraints_ParameterConstraintsItem.GetServiceTemplateParameterConstraints_OriginalConstraintsItem>();
				for (int j = 0; j < _ctx.Length("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].OriginalConstraints.Length"); j++) {
					GetServiceTemplateParameterConstraintsResponse.GetServiceTemplateParameterConstraints_ParameterConstraintsItem.GetServiceTemplateParameterConstraints_OriginalConstraintsItem originalConstraintsItem = new GetServiceTemplateParameterConstraintsResponse.GetServiceTemplateParameterConstraints_ParameterConstraintsItem.GetServiceTemplateParameterConstraints_OriginalConstraintsItem();
					originalConstraintsItem.PropertyName = _ctx.StringValue("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].OriginalConstraints["+ j +"].PropertyName");
					originalConstraintsItem.ResourceName = _ctx.StringValue("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].OriginalConstraints["+ j +"].ResourceName");
					originalConstraintsItem.ResourceType = _ctx.StringValue("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].OriginalConstraints["+ j +"].ResourceType");

					List<string> originalConstraintsItem_allowedValues1 = new List<string>();
					for (int k = 0; k < _ctx.Length("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].OriginalConstraints["+ j +"].AllowedValues.Length"); k++) {
						originalConstraintsItem_allowedValues1.Add(_ctx.StringValue("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].OriginalConstraints["+ j +"].AllowedValues["+ k +"]"));
					}
					originalConstraintsItem.AllowedValues1 = originalConstraintsItem_allowedValues1;

					parameterConstraintsItem_originalConstraints.Add(originalConstraintsItem);
				}
				parameterConstraintsItem.OriginalConstraints = parameterConstraintsItem_originalConstraints;

				List<GetServiceTemplateParameterConstraintsResponse.GetServiceTemplateParameterConstraints_ParameterConstraintsItem.GetServiceTemplateParameterConstraints_QueryErrorsItem> parameterConstraintsItem_queryErrors = new List<GetServiceTemplateParameterConstraintsResponse.GetServiceTemplateParameterConstraints_ParameterConstraintsItem.GetServiceTemplateParameterConstraints_QueryErrorsItem>();
				for (int j = 0; j < _ctx.Length("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].QueryErrors.Length"); j++) {
					GetServiceTemplateParameterConstraintsResponse.GetServiceTemplateParameterConstraints_ParameterConstraintsItem.GetServiceTemplateParameterConstraints_QueryErrorsItem queryErrorsItem = new GetServiceTemplateParameterConstraintsResponse.GetServiceTemplateParameterConstraints_ParameterConstraintsItem.GetServiceTemplateParameterConstraints_QueryErrorsItem();
					queryErrorsItem.ErrorMessage = _ctx.StringValue("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].QueryErrors["+ j +"].ErrorMessage");
					queryErrorsItem.ResourceName = _ctx.StringValue("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].QueryErrors["+ j +"].ResourceName");
					queryErrorsItem.ResourceType = _ctx.StringValue("GetServiceTemplateParameterConstraints.ParameterConstraints["+ i +"].QueryErrors["+ j +"].ResourceType");

					parameterConstraintsItem_queryErrors.Add(queryErrorsItem);
				}
				parameterConstraintsItem.QueryErrors = parameterConstraintsItem_queryErrors;

				getServiceTemplateParameterConstraintsResponse_parameterConstraints.Add(parameterConstraintsItem);
			}
			getServiceTemplateParameterConstraintsResponse.ParameterConstraints = getServiceTemplateParameterConstraintsResponse_parameterConstraints;
        
			return getServiceTemplateParameterConstraintsResponse;
        }
    }
}
