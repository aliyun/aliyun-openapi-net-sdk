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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Domain.Model.V20180129
{
	public class QueryArtExtensionResponse : AcsResponse
	{

		private string requestId;

		private string objectType;

		private string materialsAndTechniques;

		private string dimensions;

		private string title;

		private string dateOrPeriod;

		private string maker;

		private string inscriptionsAndMarkings;

		private string subject;

		private string features;

		private string reference;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string ObjectType
		{
			get
			{
				return objectType;
			}
			set	
			{
				objectType = value;
			}
		}

		public string MaterialsAndTechniques
		{
			get
			{
				return materialsAndTechniques;
			}
			set	
			{
				materialsAndTechniques = value;
			}
		}

		public string Dimensions
		{
			get
			{
				return dimensions;
			}
			set	
			{
				dimensions = value;
			}
		}

		public string Title
		{
			get
			{
				return title;
			}
			set	
			{
				title = value;
			}
		}

		public string DateOrPeriod
		{
			get
			{
				return dateOrPeriod;
			}
			set	
			{
				dateOrPeriod = value;
			}
		}

		public string Maker
		{
			get
			{
				return maker;
			}
			set	
			{
				maker = value;
			}
		}

		public string InscriptionsAndMarkings
		{
			get
			{
				return inscriptionsAndMarkings;
			}
			set	
			{
				inscriptionsAndMarkings = value;
			}
		}

		public string Subject
		{
			get
			{
				return subject;
			}
			set	
			{
				subject = value;
			}
		}

		public string Features
		{
			get
			{
				return features;
			}
			set	
			{
				features = value;
			}
		}

		public string Reference
		{
			get
			{
				return reference;
			}
			set	
			{
				reference = value;
			}
		}
	}
}
