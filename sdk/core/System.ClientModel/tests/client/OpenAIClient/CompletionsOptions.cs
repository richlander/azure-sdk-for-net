// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Tests.Client;
using System.Collections.Generic;
using System.Linq;
using TestHelpers.Internal;

namespace OpenAI;

/// <summary>
/// The configuration information for a completions request.
/// Completions support a wide variety of tasks and generate text that continues from or "completes"
/// provided prompt data.
/// </summary>
public partial class CompletionsOptions
{
    /// <summary> Initializes a new instance of CompletionsOptions. </summary>
    /// <param name="prompts"> The prompts to generate completions from. </param>
    /// <exception cref="ArgumentNullException"> <paramref name="prompts"/> is null. </exception>
    public CompletionsOptions(IEnumerable<string> prompts)
    {
        if (prompts is null) throw new ArgumentNullException(nameof(prompts));

        Prompts = prompts.ToList();
        InternalStringKeyedTokenSelectionBiases = new OptionalDictionary<string, int>();
        StopSequences = new OptionalList<string>();
    }

    /// <summary> Initializes a new instance of CompletionsOptions. </summary>
    /// <param name="prompts"> The prompts to generate completions from. </param>
    /// <param name="maxTokens"> The maximum number of tokens to generate. </param>
    /// <param name="temperature">
    /// The sampling temperature to use that controls the apparent creativity of generated completions.
    /// Higher values will make output more random while lower values will make results more focused
    /// and deterministic.
    /// It is not recommended to modify temperature and top_p for the same completions request as the
    /// interaction of these two settings is difficult to predict.
    /// </param>
    /// <param name="nucleusSamplingFactor">
    /// An alternative to sampling with temperature called nucleus sampling. This value causes the
    /// model to consider the results of tokens with the provided probability mass. As an example, a
    /// value of 0.15 will cause only the tokens comprising the top 15% of probability mass to be
    /// considered.
    /// It is not recommended to modify temperature and top_p for the same completions request as the
    /// interaction of these two settings is difficult to predict.
    /// </param>
    /// <param name="internalStringKeyedTokenSelectionBiases">
    /// A map between GPT token IDs and bias scores that influences the probability of specific tokens
    /// appearing in a completions response. Token IDs are computed via external tokenizer tools, while
    /// bias scores reside in the range of -100 to 100 with minimum and maximum values corresponding to
    /// a full ban or exclusive selection of a token, respectively. The exact behavior of a given bias
    /// score varies by model.
    /// </param>
    /// <param name="user">
    /// An identifier for the caller or end user of the operation. This may be used for tracking
    /// or rate-limiting purposes.
    /// </param>
    /// <param name="choicesPerPrompt">
    /// The number of completions choices that should be generated per provided prompt as part of an
    /// overall completions response.
    /// Because this setting can generate many completions, it may quickly consume your token quota.
    /// Use carefully and ensure reasonable settings for max_tokens and stop.
    /// </param>
    /// <param name="logProbabilityCount">
    /// A value that controls the emission of log probabilities for the provided number of most likely
    /// tokens within a completions response.
    /// </param>
    /// <param name="echo">
    /// A value specifying whether completions responses should include input prompts as prefixes to
    /// their generated output.
    /// </param>
    /// <param name="stopSequences"> A collection of textual sequences that will end completions generation. </param>
    /// <param name="presencePenalty">
    /// A value that influences the probability of generated tokens appearing based on their existing
    /// presence in generated text.
    /// Positive values will make tokens less likely to appear when they already exist and increase the
    /// model's likelihood to output new topics.
    /// </param>
    /// <param name="frequencyPenalty">
    /// A value that influences the probability of generated tokens appearing based on their cumulative
    /// frequency in generated text.
    /// Positive values will make tokens less likely to appear as their frequency increases and
    /// decrease the likelihood of the model repeating the same statements verbatim.
    /// </param>
    /// <param name="generationSampleCount">
    /// A value that controls how many completions will be internally generated prior to response
    /// formulation.
    /// When used together with n, best_of controls the number of candidate completions and must be
    /// greater than n.
    /// Because this setting can generate many completions, it may quickly consume your token quota.
    /// Use carefully and ensure reasonable settings for max_tokens and stop.
    /// </param>
    /// <param name="internalShouldStreamResponse"> A value indicating whether chat completions should be streamed for this request. </param>
    /// <param name="internalNonAzureModelName">
    /// The model name to provide as part of this completions request.
    /// Not applicable to Azure OpenAI, where deployment information should be included in the Azure
    /// resource URI that's connected to.
    /// </param>
    internal CompletionsOptions(IList<string> prompts, int? maxTokens, float? temperature, float? nucleusSamplingFactor, IDictionary<string, int> internalStringKeyedTokenSelectionBiases, string user, int? choicesPerPrompt, int? logProbabilityCount, bool? echo, IList<string> stopSequences, float? presencePenalty, float? frequencyPenalty, int? generationSampleCount, bool? internalShouldStreamResponse, string internalNonAzureModelName)
    {
        Prompts = prompts;
        MaxTokens = maxTokens;
        Temperature = temperature;
        NucleusSamplingFactor = nucleusSamplingFactor;
        InternalStringKeyedTokenSelectionBiases = internalStringKeyedTokenSelectionBiases;
        User = user;
        ChoicesPerPrompt = choicesPerPrompt;
        LogProbabilityCount = logProbabilityCount;
        Echo = echo;
        StopSequences = stopSequences;
        PresencePenalty = presencePenalty;
        FrequencyPenalty = frequencyPenalty;
        GenerationSampleCount = generationSampleCount;
        InternalShouldStreamResponse = internalShouldStreamResponse;
        InternalNonAzureModelName = internalNonAzureModelName;
    }

    /// <summary> The prompts to generate completions from. </summary>
    public IList<string> Prompts { get; }
    /// <summary> The maximum number of tokens to generate. </summary>
    public int? MaxTokens { get; set; }
    /// <summary>
    /// The sampling temperature to use that controls the apparent creativity of generated completions.
    /// Higher values will make output more random while lower values will make results more focused
    /// and deterministic.
    /// It is not recommended to modify temperature and top_p for the same completions request as the
    /// interaction of these two settings is difficult to predict.
    /// </summary>
    public float? Temperature { get; set; }
    /// <summary>
    /// An alternative to sampling with temperature called nucleus sampling. This value causes the
    /// model to consider the results of tokens with the provided probability mass. As an example, a
    /// value of 0.15 will cause only the tokens comprising the top 15% of probability mass to be
    /// considered.
    /// It is not recommended to modify temperature and top_p for the same completions request as the
    /// interaction of these two settings is difficult to predict.
    /// </summary>
    public float? NucleusSamplingFactor { get; set; }
    /// <summary>
    /// A map between GPT token IDs and bias scores that influences the probability of specific tokens
    /// appearing in a completions response. Token IDs are computed via external tokenizer tools, while
    /// bias scores reside in the range of -100 to 100 with minimum and maximum values corresponding to
    /// a full ban or exclusive selection of a token, respectively. The exact behavior of a given bias
    /// score varies by model.
    /// </summary>
    public IDictionary<string, int> InternalStringKeyedTokenSelectionBiases { get; }
    /// <summary>
    /// An identifier for the caller or end user of the operation. This may be used for tracking
    /// or rate-limiting purposes.
    /// </summary>
    public string User { get; set; }
    /// <summary>
    /// The number of completions choices that should be generated per provided prompt as part of an
    /// overall completions response.
    /// Because this setting can generate many completions, it may quickly consume your token quota.
    /// Use carefully and ensure reasonable settings for max_tokens and stop.
    /// </summary>
    public int? ChoicesPerPrompt { get; set; }
    /// <summary>
    /// A value that controls the emission of log probabilities for the provided number of most likely
    /// tokens within a completions response.
    /// </summary>
    public int? LogProbabilityCount { get; set; }
    /// <summary>
    /// A value specifying whether completions responses should include input prompts as prefixes to
    /// their generated output.
    /// </summary>
    public bool? Echo { get; set; }
    /// <summary> A collection of textual sequences that will end completions generation. </summary>
    public IList<string> StopSequences { get; }
    /// <summary>
    /// A value that influences the probability of generated tokens appearing based on their existing
    /// presence in generated text.
    /// Positive values will make tokens less likely to appear when they already exist and increase the
    /// model's likelihood to output new topics.
    /// </summary>
    public float? PresencePenalty { get; set; }
    /// <summary>
    /// A value that influences the probability of generated tokens appearing based on their cumulative
    /// frequency in generated text.
    /// Positive values will make tokens less likely to appear as their frequency increases and
    /// decrease the likelihood of the model repeating the same statements verbatim.
    /// </summary>
    public float? FrequencyPenalty { get; set; }
    /// <summary>
    /// A value that controls how many completions will be internally generated prior to response
    /// formulation.
    /// When used together with n, best_of controls the number of candidate completions and must be
    /// greater than n.
    /// Because this setting can generate many completions, it may quickly consume your token quota.
    /// Use carefully and ensure reasonable settings for max_tokens and stop.
    /// </summary>
    public int? GenerationSampleCount { get; set; }
    /// <summary> A value indicating whether chat completions should be streamed for this request. </summary>
    public bool? InternalShouldStreamResponse { get; set; }
    /// <summary>
    /// The model name to provide as part of this completions request.
    /// Not applicable to Azure OpenAI, where deployment information should be included in the Azure
    /// resource URI that's connected to.
    /// </summary>
    public string InternalNonAzureModelName { get; set; }
}

