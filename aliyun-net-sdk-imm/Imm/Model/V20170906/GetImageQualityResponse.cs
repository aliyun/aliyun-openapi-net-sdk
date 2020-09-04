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

namespace Aliyun.Acs.imm.Model.V20170906
{
	public class GetImageQualityResponse : AcsResponse
	{

		private string requestId;

		private string imageUri;

		private GetImageQuality_ImageQuality imageQuality;

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

		public string ImageUri
		{
			get
			{
				return imageUri;
			}
			set	
			{
				imageUri = value;
			}
		}

		public GetImageQuality_ImageQuality ImageQuality
		{
			get
			{
				return imageQuality;
			}
			set	
			{
				imageQuality = value;
			}
		}

		public class GetImageQuality_ImageQuality
		{

			private float? overallScore;

			private float? clarityScore;

			private float? clarity;

			private float? exposureScore;

			private float? exposure;

			private float? contrastScore;

			private float? contrast;

			private float? colorScore;

			private float? color;

			private float? compositionScore;

			public float? OverallScore
			{
				get
				{
					return overallScore;
				}
				set	
				{
					overallScore = value;
				}
			}

			public float? ClarityScore
			{
				get
				{
					return clarityScore;
				}
				set	
				{
					clarityScore = value;
				}
			}

			public float? Clarity
			{
				get
				{
					return clarity;
				}
				set	
				{
					clarity = value;
				}
			}

			public float? ExposureScore
			{
				get
				{
					return exposureScore;
				}
				set	
				{
					exposureScore = value;
				}
			}

			public float? Exposure
			{
				get
				{
					return exposure;
				}
				set	
				{
					exposure = value;
				}
			}

			public float? ContrastScore
			{
				get
				{
					return contrastScore;
				}
				set	
				{
					contrastScore = value;
				}
			}

			public float? Contrast
			{
				get
				{
					return contrast;
				}
				set	
				{
					contrast = value;
				}
			}

			public float? ColorScore
			{
				get
				{
					return colorScore;
				}
				set	
				{
					colorScore = value;
				}
			}

			public float? Color
			{
				get
				{
					return color;
				}
				set	
				{
					color = value;
				}
			}

			public float? CompositionScore
			{
				get
				{
					return compositionScore;
				}
				set	
				{
					compositionScore = value;
				}
			}
		}
	}
}
